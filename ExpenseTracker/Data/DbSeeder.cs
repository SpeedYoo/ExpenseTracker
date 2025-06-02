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
        private static readonly Random _random = new Random();

        public static void Seed(AppDbContext ctx)
        {
            if (!ctx.Accounts.Any())
            {
                var accounts = new List<Account>();

                for (int i = 1; i <= 3; i++)
                {
                    accounts.Add(new Account
                    {
                        Name = $"Konto {i}",
                        Description = $"Opis konta {i}",
                        Balance = 0m,
                        CreatedAt = DateTime.UtcNow.AddDays(-_random.Next(10, 100))
                    });
                }

                ctx.Accounts.AddRange(accounts);
                ctx.SaveChanges(); // zapisujemy, żeby mieć AccountId
            }

            var accountsFromDb = ctx.Accounts.ToList();

            foreach (var account in accountsFromDb)
            {
                if (!ctx.Categories.Any(c => c.AccountId == account.AccountId))
                {
                    var categories = new List<Category>
                {
                    new Category { Name = "Pensja", Type = TransactionType.Income, AccountId = account.AccountId },
                    new Category { Name = "Premia", Type = TransactionType.Income, AccountId = account.AccountId },
                    new Category { Name = "Zakupy", Type = TransactionType.Expense, AccountId = account.AccountId },
                    new Category { Name = "Transport", Type = TransactionType.Expense, AccountId = account.AccountId },
                    new Category { Name = "Rozrywka", Type = TransactionType.Expense, AccountId = account.AccountId }
                };

                    ctx.Categories.AddRange(categories);
                    ctx.SaveChanges(); // zapisujemy, żeby mieć CategoryId
                }
            }

            if (!ctx.Transactions.Any())
            {
                var allCategories = ctx.Categories.ToList();
                var transactions = new List<Transaction>();

                foreach (var account in accountsFromDb)
                {
                    var categoriesForAccount = allCategories.Where(c => c.AccountId == account.AccountId).ToList();

                    for (int i = 0; i < _random.Next(20, 50); i++)
                    {
                        var category = categoriesForAccount[_random.Next(categoriesForAccount.Count)];

                        var amount = category.Type == TransactionType.Income
                            ? _random.Next(1000, 10000)
                            : _random.Next(10, 1000);

                        var daysAgo = _random.Next(1, 90);
                        var date = DateTime.UtcNow.AddDays(-daysAgo);

                        transactions.Add(new Transaction
                        {
                            AccountId = account.AccountId,
                            CategoryId = category.CategoryId,
                            Amount = amount,
                            OccurredAt = date,
                            Description = $"{category.Name} - transakcja {i + 1}",
                            CreatedAt = date
                        });

                        // Aktualizacja salda konta (w pamięci)
                        account.Balance += category.Type == TransactionType.Income ? amount : -amount;
                    }
                }

                ctx.Transactions.AddRange(transactions);
                ctx.SaveChanges();
            }
        }
    }
}
