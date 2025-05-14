using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Services.Implementations;
using ExpenseTracker.Services.Models;

namespace ExpenseTracker.Views
{
    public partial class DashboardView : UserControl
    {
        private readonly Account _currentAccount;
        private readonly SummaryService _summaryService;
        private readonly TransactionService _txService;


        public DashboardView(Account account)
        {
            InitializeComponent();
            _summaryService = new SummaryService();
            _txService = new TransactionService();
            _currentAccount = account;
        }
        private async Task LoadSummaryAsync()
        {
            var summary = await _summaryService.GetAccountSummaryAsync(_currentAccount.AccountId);

            lblIncomes.Text = summary.TotalIncomes.ToString("C");
            lblExpenses.Text = summary.TotalExpenses.ToString("C");
            lblCurrent.Text = summary.CurrentBalance.ToString("C");

            PopulateIncomeExpenseChart(summary);
            await PopulateExpenseByCategoryChartAsync();
        }


        private void PopulateIncomeExpenseChart(AccountSummary s)
        {
            var chart = chartIncomeExpense;
            chart.Series.Clear();

            var serInc = new Series("Przychody")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "Area1",
                Legend = "L1",
                IsValueShownAsLabel = true,
                Color = Color.Green
            };
            serInc.Points.AddXY("Przychody", s.TotalIncomes);

            var serExp = new Series("Wydatki")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "Area1",
                Legend = "L1",
                IsValueShownAsLabel = true,
                Color = Color.Red
            };
            serExp.Points.AddXY("Wydatki", s.TotalExpenses);

            chart.Series.Add(serInc);
            chart.Series.Add(serExp);

            var ax = chart.ChartAreas["Area1"].AxisX;
            ax.Interval = 1;
        }

        private async Task PopulateExpenseByCategoryChartAsync()
        {
            // pobierz pełne listy wydatków
            var expenses = await _txService.GetForAccountExpensesAsync(_currentAccount.AccountId);

            // grupuj po kategorii
            var byCat = expenses
                .GroupBy(t => t.Category?.Name ?? "Brak")
                .Select(g => new { Name = g.Key, Sum = g.Sum(t => t.Amount) })
                .Where(x => x.Sum > 0)
                .ToList();

            var chart = chartExpenseByCategory;
            chart.Series.Clear();

            var ser = new Series("Wydatki")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "Area2",
                Legend = "L2",
                IsValueShownAsLabel = true
            };

            foreach (var item in byCat)
            {
                int idx = ser.Points.AddXY(item.Name, item.Sum);

                var dp = ser.Points[idx];
                dp.Label = $"{item.Name}: {item.Sum:C}";
            }

            chart.Series.Add(ser);
            chart.Legends["L2"].Docking = Docking.Right;
        }


        private void DashboardView_Load(object sender, EventArgs e)
        {
            refreshView();
        }

        private async void refreshView()
        {
            await LoadSummaryAsync();
        }

        private void DashboardView_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                refreshView();
        }
    }
}
