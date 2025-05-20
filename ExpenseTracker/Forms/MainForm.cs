using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetManagerApp;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ExpenseTracker.Forms
{
    public partial class MainForm : Form
    {
        private Account _currentAccount;

        public MainForm(Account account)
        {
            InitializeComponent();
            _currentAccount = account;

            user_name.Text = _currentAccount.Name;

            ShowView(new DashboardView(_currentAccount));
        }

        private void ShowView(UserControl view)
        {
            panel_main.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel_main.Controls.Add(view);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //
        }

        private void expenses_btn_Click(object sender, EventArgs e)
        {
            ShowView(new ExpenseView(_currentAccount));
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            ShowView(new DashboardView(_currentAccount));
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            ShowView(new IncomeView(_currentAccount));
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            ShowView(new CategoryView(_currentAccount));
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            using var sel = new AccountSelectionForm();
            var dr = sel.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _currentAccount = sel.SelectedAccount;
                user_name.Text = _currentAccount.Name;
                ShowView(new DashboardView(_currentAccount));
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowView(new TransactionView(_currentAccount));
        }

        private void addtransaction_btn_Click(object sender, EventArgs e)
        {
            ShowView(new TransactionControl(_currentAccount));
        }
    }
}
