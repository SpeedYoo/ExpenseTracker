using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data.Models;

namespace ExpenseTracker.Data
{
    internal static class DbSeeder
    {
        public static void Seed(AppDbContext ctx)
        {
            if (!ctx.Accounts.Any())
            {
                ctx.Accounts.Add(new Account
                {
                    Name = "Domyślne konto",
                    Description = "Konto domyślne",
                    Balance = 0m,
                    CreatedAt = DateTime.UtcNow
                });
            }

            if (!ctx.Categories.Any(c => c.AccountId == 1))
            {
                ctx.Categories.AddRange(
                    new Category { Name = "Pensja", Type = TransactionType.Income, AccountId = 1 },
                    new Category { Name = "Zakupy", Type = TransactionType.Expense, AccountId = 1 },
                    new Category { Name = "Transport", Type = TransactionType.Expense, AccountId = 1 }
                );
            }


            if (!ctx.Transactions.Any())
            {
                ctx.Transactions.AddRange(
                    new Transaction
                    {
                        AccountId = 1,
                        CategoryId = 1,
                        Amount = 5000m,
                        OccurredAt = DateTime.UtcNow.AddDays(-30),
                        Description = "Wypłata miesięczna",
                        CreatedAt = DateTime.UtcNow.AddDays(-30)
                    },
                    new Transaction
                    {
                        AccountId = 1,
                        CategoryId = 2,
                        Amount = 150m,
                        OccurredAt = DateTime.UtcNow.AddDays(-10),
                        Description = "Zakupy spożywcze",
                        CreatedAt = DateTime.UtcNow.AddDays(-10)
                    },
                    new Transaction
                    {
                        AccountId = 1,
                        CategoryId = 3,
                        Amount = 20m,
                        OccurredAt = DateTime.UtcNow.AddDays(-5),
                        Description = "Bilet komunikacji",
                        CreatedAt = DateTime.UtcNow.AddDays(-5)
                    }
                );
            }

            ctx.SaveChanges();
        }
    }
}
