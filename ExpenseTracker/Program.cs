
using System.Diagnostics;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace BudgetManagerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Setup configuration
            using (var ctx = new AppDbContext())
            {
                ctx.Database.Migrate();
                DbSeeder.Seed(ctx);
            }

            ApplicationConfiguration.Initialize();

            using var selectForm = new AccountSelectionForm();
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                var account = selectForm.SelectedAccount;
                Application.Run(new MainForm(account));
            }
        }
    }
}