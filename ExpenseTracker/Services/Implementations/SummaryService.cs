using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Data;
using ExpenseTracker.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services.Implementations
{
    internal class SummaryService
    {
        public async Task<AccountSummary> GetAccountSummaryAsync(int accountId)
        {
            using var ctx = new AppDbContext();

            var account = await ctx.Accounts
                                   .Where(a => a.AccountId == accountId)
                                   .SingleAsync();

            var incomes = await ctx.Transactions
                                    .Where(t => t.AccountId == accountId
                                             && t.Category.Type == TransactionType.Income)
                                    .SumAsync(t => t.Amount);

            var expenses = await ctx.Transactions
                                    .Where(t => t.AccountId == accountId
                                             && t.Category.Type == TransactionType.Expense)
                                    .SumAsync(t => t.Amount);

            return new AccountSummary
            {
                InitialBalance = account.Balance,
                TotalIncomes = incomes,
                TotalExpenses = expenses,
                CurrentBalance = account.Balance + incomes - expenses
            };
        }
    }
}
