using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Services.Implementations;

namespace ExpenseTracker.Views
{
    public partial class ExpenseView : UserControl
    {
        private readonly Account _currentAccount;
        private readonly TransactionService _txService;
        private readonly CategoryService _categoryService;
        private List<Transaction> _transactions = new List<Transaction>();

        public ExpenseView(Account account)
        {
            InitializeComponent();

            _txService = new TransactionService();
            _categoryService = new CategoryService();
            _currentAccount = account;


            // Konfiguracja DataGridView
            ExpenseDataView.AutoGenerateColumns = false;
            ExpenseDataView.AllowUserToAddRows = false;
            ExpenseDataView.Columns.Clear();
            ExpenseDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = nameof(Transaction.TransactionId),
                HeaderText = "ID",
                Width = 50
            });
            ExpenseDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                DataPropertyName = nameof(Transaction.OccurredAt),
                HeaderText = "Data",
                Width = 120
            });
            ExpenseDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                DataPropertyName = nameof(Transaction.Category), // wyświetlamy w CellFormatting
                HeaderText = "Kategoria",
                Width = 150
            });
            ExpenseDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAmount",
                DataPropertyName = nameof(Transaction.Amount),
                HeaderText = "Kwota",
                Width = 80
            });
            ExpenseDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDesc",
                DataPropertyName = nameof(Transaction.Description),
                HeaderText = "Opis",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // CellFormatting dla kolumny kategorii
            ExpenseDataView.CellFormatting += ExpenseDataView_CellFormatting;
        }

        private void ExpenseView_Load(object sender, EventArgs e)
        {
            refreshView();
        }



        private async Task PopulateCategoriesAsync()
        {
            var expenseCats = await _categoryService
                .GetForAccountExpensesCategoriesAsync(_currentAccount.AccountId);

            comboBoxCategory.DataSource = expenseCats;
            comboBoxCategory.DisplayMember = nameof(Category.Name);
            comboBoxCategory.ValueMember = nameof(Category.CategoryId);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task LoadExpensesAsync()
        {
            _transactions = await _txService.GetForAccountExpensesAsync(_currentAccount.AccountId);
            ExpenseDataView.DataSource = new BindingList<Transaction>(_transactions);
            ExpenseDataView.Refresh();
        }

        private void ExpenseDataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ExpenseDataView.Columns[e.ColumnIndex].Name == "colCategory")
            {
                var row = ExpenseDataView.Rows[e.RowIndex];
                if (row.IsNewRow) return;
                if (row.DataBoundItem is Transaction tx && tx.Category != null)
                {
                    e.Value = tx.Category.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem is not Category cat)
            {
                MessageBox.Show("Wybierz kategorię.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var local = dateTimePickerOccurredAt.Value;
            var occurredUtc = DateTime.SpecifyKind(local, DateTimeKind.Local).ToUniversalTime();

            var tx = new Transaction
            {
                AccountId = _currentAccount.AccountId,
                CategoryId = cat.CategoryId,
                Amount = AmoutField.Value,
                OccurredAt = occurredUtc,
                Description = txtDescription.Text.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            await _txService.CreateAsync(tx);
            await LoadExpensesAsync();
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            if (ExpenseDataView.CurrentRow?.DataBoundItem is Transaction tx)
            {
                var ok = MessageBox.Show(
                    $"Usuń transakcję #{tx.TransactionId}?",
                    "Potwierdź",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (!ok) return;
                await _txService.DeleteAsync(tx.TransactionId);
                await LoadExpensesAsync();
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (ExpenseDataView.CurrentRow?.DataBoundItem is Transaction tx)
            {
                if (comboBoxCategory.SelectedItem is not Category cat)
                {
                    MessageBox.Show("Wybierz kategorię.", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var local = dateTimePickerOccurredAt.Value;
                tx.CategoryId = cat.CategoryId;
                tx.Amount = AmoutField.Value;
                tx.OccurredAt = DateTime.SpecifyKind(local, DateTimeKind.Local).ToUniversalTime();
                tx.Description = txtDescription.Text.Trim();

                await _txService.UpdateAsync(tx);
                await LoadExpensesAsync();
            }
        }

        private async void refreshView()
        {
            await PopulateCategoriesAsync();
            await LoadExpensesAsync();
        }

        private void ExpenseView_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                refreshView();
        }
    }
}
