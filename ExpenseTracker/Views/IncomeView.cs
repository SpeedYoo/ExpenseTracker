using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Core.Interfaces;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Services.Implementations;

namespace ExpenseTracker.Views
{
    public partial class IncomeView : UserControl
    {
        private readonly Account _currentAccount;
        private readonly TransactionService _txService;
        private readonly CategoryService _categoryService;

        private List<Transaction> _transactions = new();

        public IncomeView(Account account)
        {
            InitializeComponent();

            _txService = new TransactionService();
            _categoryService = new CategoryService();
            _currentAccount = account;

            this.Load += IncomeView_Load;

            // konfiguracja kolumn
            IncomeDataView.AutoGenerateColumns = false;
            IncomeDataView.AllowUserToAddRows = false;
            IncomeDataView.Columns.Clear();
            IncomeDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = nameof(Transaction.TransactionId),
                HeaderText = "ID",
                Width = 50
            });
            IncomeDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                DataPropertyName = nameof(Transaction.OccurredAt),
                HeaderText = "Data",
                Width = 120
            });
            // kolumna dla kategorii — wypiszemy ją w CellFormatting
            IncomeDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                DataPropertyName = nameof(Transaction.Category),
                HeaderText = "Kategoria",
                Width = 150
            });
            IncomeDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAmount",
                DataPropertyName = nameof(Transaction.Amount),
                HeaderText = "Kwota",
                Width = 80
            });
            IncomeDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDesc",
                DataPropertyName = nameof(Transaction.Description),
                HeaderText = "Opis",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            IncomeDataView.CellFormatting += IncomeDataView_CellFormatting;
        }
        private void IncomeDataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // tylko kolumna „Kategoria”
            if (IncomeDataView.Columns[e.ColumnIndex].Name != "colCategory")
                return;

            // upewnij się, że to prawdziwy wiersz danych
            if (e.RowIndex < 0 || e.RowIndex >= IncomeDataView.Rows.Count)
                return;

            var row = IncomeDataView.Rows[e.RowIndex];
            if (row.IsNewRow)
                return;

            if (row.DataBoundItem is Transaction tx && tx.Category != null)
            {
                e.Value = tx.Category.Name;
                e.FormattingApplied = true;
            }
        }


        private void IncomeView_Load(object sender, EventArgs e)
        {
            refreshView();
        }

        private async Task PopulateCategoriesAsync()
        {
            var incomeCats = await _categoryService
                .GetForAccountIncomeCategoriesAsync(_currentAccount.AccountId);

            comboBoxCategory.DataSource = incomeCats;
            comboBoxCategory.DisplayMember = nameof(Category.Name);
            comboBoxCategory.ValueMember = nameof(Category.CategoryId);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task LoadTransactionsAsync()
        {
            _transactions = await _txService.GetForAccountIncomeAsync(_currentAccount.AccountId);
            IncomeDataView.DataSource = new BindingList<Transaction>(_transactions);
            IncomeDataView.Refresh();
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem is not Category cat)
            {
                MessageBox.Show("Wybierz kategorię.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var local = dateTimePickerOccurredAt.Value;
            var occurredUtc = DateTime.SpecifyKind(local, DateTimeKind.Local).ToUniversalTime();

            var tx = new Transaction
            {
                AccountId = _currentAccount.AccountId,
                CategoryId = cat.CategoryId,
                Amount = amountField.Value,
                OccurredAt = occurredUtc,
                Description = txtDescription.Text.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            await _txService.CreateAsync(tx);
            await LoadTransactionsAsync();

            comboBoxCategory.SelectedIndex = -1;
            amountField.Value = 0;
            txtDescription.Clear();
            dateTimePickerOccurredAt.Value = DateTime.Now;

        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            if (IncomeDataView.CurrentRow?.DataBoundItem is Transaction tx)
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

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (IncomeDataView.CurrentRow?.DataBoundItem is Transaction tx)
            {
                if (comboBoxCategory.SelectedItem is not Category cat)
                {
                    MessageBox.Show("Wybierz kategorię.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var local = dateTimePickerOccurredAt.Value;
                tx.CategoryId = cat.CategoryId;
                tx.Amount = amountField.Value;
                tx.OccurredAt = DateTime.SpecifyKind(local, DateTimeKind.Local).ToUniversalTime();
                tx.Description = txtDescription.Text.Trim();

                await _txService.UpdateAsync(tx);
                await LoadTransactionsAsync();
            }
        }

        private async void refreshView()
        {
            await PopulateCategoriesAsync();
            await LoadTransactionsAsync();
        }

        private void IncomeView_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                refreshView();
        }
    }

}
