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
    public partial class TransactionControl : UserControl
    {
        private readonly Account _account;
        private readonly TransactionService _txService;
        private readonly CategoryService _catService;

        public event Func<Transaction, Task> TransactionSaved;
        public event Action TransactionCanceled;

        public TransactionControl(Account account)
        {
            InitializeComponent();

            _account = account;
            _txService = new TransactionService();
            _catService = new CategoryService();

            // Events
            btnSave.Click += BtnSave_Click;
            radioIncome.CheckedChanged += TypeRadio_CheckedChanged;
            radioExpense.CheckedChanged += TypeRadio_CheckedChanged;

            // Initialize
            radioExpense.Checked = true;
            _ = LoadCategoriesAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            List<Category> list;
            if (radioExpense.Checked)
                list = await _catService.GetForAccountIncomeCategoriesAsync(_account.AccountId);
            else
                list = await _catService.GetForAccountExpensesCategoriesAsync(_account.AccountId);

            comboCategory.DataSource = list;
            comboCategory.DisplayMember = nameof(Category.Name);
            comboCategory.ValueMember = nameof(Category.CategoryId);
            comboCategory.SelectedIndex = -1;
        }

        private void TypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            _ = LoadCategoriesAsync();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (comboCategory.SelectedItem is not Category cat)
            {
                MessageBox.Show("Wybierz kategorię.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtAmount.Text.Trim(), out var amount))
            {
                MessageBox.Show("Nieprawidłowa kwota.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var local = dateTimePicker.Value;
            var occurredUtc = DateTime.SpecifyKind(local, DateTimeKind.Local).ToUniversalTime();

            var tx = new Transaction
            {
                AccountId = _account.AccountId,
                CategoryId = cat.CategoryId,
                Amount = amount,
                OccurredAt = occurredUtc,
                Description = txtDescription.Text.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            await _txService.CreateAsync(tx);
            if (TransactionSaved != null)
                await TransactionSaved(tx);
        }
    }
}
