using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BudgetManagerApp
{
    public partial class AccountSelectionForm : Form
    {

        private readonly AppDbContext _ctx = new AppDbContext();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Account SelectedAccount { get; private set; }

        public AccountSelectionForm()
        {
            InitializeComponent();
        }

        private async void AccountSelectionForm_Load(object sender, EventArgs e)
        {
            var accounts = await _ctx.Accounts
                                     .OrderBy(a => a.Name)
                                     .ToListAsync();
            cboAccounts.DataSource = accounts;
            cboAccounts.DisplayMember = "Name";
            cboAccounts.ValueMember = "AccountId";

            if (!accounts.Any())
                OpenNewAccountDialog();
        }

        private async void OpenNewAccountDialog()
        {
            using var form = new AccountCreationForm();
            if (form.ShowDialog() == DialogResult.OK)
            {        
                var accounts = await _ctx.Accounts.OrderBy(a => a.Name).ToListAsync();
                cboAccounts.DataSource = accounts;
                cboAccounts.SelectedValue = form.CreatedAccountId;
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cboAccounts.SelectedItem is Account acct)
            {
                SelectedAccount = acct;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Proszę wybrać konto lub utworzyć nowe.", "Uwaga",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            OpenNewAccountDialog();
        }

    }
}
