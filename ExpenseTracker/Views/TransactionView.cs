using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Core.Interfaces;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Services.Implementations;

namespace ExpenseTracker.Views
{
    public partial class TransactionView : UserControl
    {
        private readonly Account _currentAccount;
        private readonly TransactionService _txService;
        private BindingList<Transaction> _transactions;
        private ContextMenuStrip _contextMenu;

        private List<Transaction> _allTransactions;

        private List<Category> _categories;

        private readonly ICategoryService _categoryService;

        public TransactionView(Account account)
        {
            InitializeComponent();

            _currentAccount = account;
            _txService = new TransactionService();
            _categoryService = new CategoryService();
            _transactions = new BindingList<Transaction>();

            this.Load += TransactionView_Load;

            // Konfiguracja DataGridView
            dataGridViewTransactions.AutoGenerateColumns = false;
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.Columns.Clear();

            // Kolumna Data
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                DataPropertyName = nameof(Transaction.OccurredAt),
                HeaderText = "Data",
                Width = 120
            });

            // Kolumna Kategoria
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                DataPropertyName = nameof(Transaction.Category),
                HeaderText = "Kategoria",
                Width = 150
            });

            // Kolumna Kwota
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAmount",
                DataPropertyName = nameof(Transaction.Amount),
                HeaderText = "Kwota",
                Width = 80
            });

            // Kolumna Opis
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDesc",
                DataPropertyName = nameof(Transaction.Description),
                HeaderText = "Opis",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Obsługa formatowania komórek
            dataGridViewTransactions.CellFormatting += DataGridViewTransactions_CellFormatting;

            // Kontekstowe menu
            _contextMenu = new ContextMenuStrip();
            _contextMenu.Items.Add("Edytuj", null, OnEditClick);
            _contextMenu.Items.Add("Usuń", null, OnDeleteClick);
            dataGridViewTransactions.MouseDown += DataGridViewTransactions_MouseDown;


            textBox1.TextChanged += (s, e) => ApplyFilters();
            radioButtonIncome.CheckedChanged += (s, e) => ApplyFilters();
            radioButtonExpense.CheckedChanged += (s, e) => ApplyFilters();
            dateTimePicker1.ValueChanged += (s, e) => ApplyFilters();
            checkBoxUseDate.CheckedChanged += (s, e) => ApplyFilters();
            comboBoxCategory.SelectedIndexChanged += (s, e) => ApplyFilters();

            radioButtonAll.Checked = true; // Domyślnie wszystkie transakcje
        }

        private async void TransactionView_Load(object sender, EventArgs e)
        {
            await LoadTransactionsAsync();
            await LoadCategoriesAsync();
        }

        private async Task LoadTransactionsAsync()
        {
            var incomes = await _txService.GetForAccountIncomeAsync(_currentAccount.AccountId);
            var expenses = await _txService.GetForAccountExpensesAsync(_currentAccount.AccountId);

            _allTransactions = incomes.Concat(expenses)
                                     .OrderByDescending(t => t.OccurredAt)
                                     .ToList();

            ApplyFilters();
        }


        private async Task LoadCategoriesAsync()
        {
            List<Category> categories = await _categoryService
                .GetForAccountCategoriesAsync(_currentAccount.AccountId);

            var categoriesWithAllOption = new List<Category>
    {
        new Category { CategoryId = 0, Name = "Wszystkie" }
    };
            categoriesWithAllOption.AddRange(categories);

            comboBoxCategory.DataSource = categoriesWithAllOption;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            if (_allTransactions == null) return;

            var filtered = _allTransactions.AsEnumerable();

            // Filtrowanie po nazwie
            string keyword = textBox1.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                filtered = filtered.Where(t =>
                    (t.Description != null && t.Description.ToLower().Contains(keyword)) ||
                    (t.Category != null && t.Category.Name.ToLower().Contains(keyword)));
            }

            // Filtrowanie po typie
            if (radioButtonIncome.Checked)
            {
                filtered = filtered.Where(t => t.Category.Type == TransactionType.Income);
            }
            else if (radioButtonExpense.Checked)
            {
                filtered = filtered.Where(t => t.Category.Type == TransactionType.Expense);
            }

            //Filtrowanie po dacie, tylko jeśli checkbox jest zaznaczony
            if (checkBoxUseDate.Checked)
            {
                var selectedDate = dateTimePicker1.Value.Date;
                filtered = filtered.Where(t => t.OccurredAt.Date == selectedDate);
            }

            if (comboBoxCategory.SelectedItem is Category selectedCategory && selectedCategory.CategoryId != 0)
            {
                filtered = filtered.Where(t => t.Category?.CategoryId == selectedCategory.CategoryId);
            }

            _transactions = new BindingList<Transaction>(filtered.ToList());
            dataGridViewTransactions.DataSource = _transactions;
        }

        private void DataGridViewTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = dataGridViewTransactions;

            // Formatowanie kolumny Kategoria
            if (dgv.Columns[e.ColumnIndex].Name == "colCategory")
            {
                var row = dgv.Rows[e.RowIndex];
                if (row.IsNewRow) return;
                if (row.DataBoundItem is Transaction tx && tx.Category != null)
                {
                    e.Value = tx.Category.Name;
                    e.FormattingApplied = true;
                }
            }

            // Formatowanie kolumny Kwota: + zielony, - czerwony
            if (dgv.Columns[e.ColumnIndex].Name == "colAmount")
            {
                var row = dgv.Rows[e.RowIndex];
                if (row.IsNewRow) return;
                if (row.DataBoundItem is Transaction tx)
                {
                    bool isIncome = tx.Category?.Type == TransactionType.Income;
                    var sign = isIncome ? "+" : "-";
                    e.Value = string.Format("{0}{1:C}", sign, tx.Amount);
                    e.CellStyle.ForeColor = isIncome ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    e.FormattingApplied = true;
                }
            }
        }

        private void DataGridViewTransactions_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewTransactions.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridViewTransactions.ClearSelection();
                    dataGridViewTransactions.Rows[hit.RowIndex].Selected = true;
                    _contextMenu.Show(dataGridViewTransactions, e.Location);
                }
            }
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.CurrentRow?.DataBoundItem is Transaction tx)
            {
                // TODO: otwórz formularz edycji i odśwież
                MessageBox.Show($"Edycja transakcji #{tx.TransactionId}");
            }
        }

        private async void OnDeleteClick(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.CurrentRow?.DataBoundItem is Transaction tx)
            {
                var ok = MessageBox.Show(
                    $"Usuń transakcję #{tx.TransactionId}?",
                    "Potwierdź",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (!ok) return;
                await _txService.DeleteAsync(tx.TransactionId);
                await LoadTransactionsAsync();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
