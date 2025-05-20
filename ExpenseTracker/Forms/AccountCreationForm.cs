using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;

namespace ExpenseTracker.Forms
{
    public partial class AccountCreationForm : Form
    {

        private readonly AppDbContext _ctx = new AppDbContext();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CreatedAccountId { get; private set; }

        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nazwa konta nie może być pusta.", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var account = new Account
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Balance = numInitialBalance.Value,
                CreatedAt = DateTime.UtcNow
            };

            _ctx.Accounts.Add(account);
            await _ctx.SaveChangesAsync();

            CreatedAccountId = account.AccountId;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
