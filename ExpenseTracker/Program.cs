
using System.Diagnostics;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Forms;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            using (var ctx = new AppDbContext())
            {
                ctx.Database.Migrate(); // migracja
                DbSeeder.Seed(ctx);  // seeder jesli baza danych jest pusta
            }


            using var selectForm = new AccountSelectionForm();
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                Account account = selectForm.SelectedAccount;

                Application.Run(new MainForm(account));
            }


            //Application.Run(new AccountSelectionForm());
        }
    }
}