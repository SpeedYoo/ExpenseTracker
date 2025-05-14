using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Core.Interfaces;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services.Implementations
{
    internal class TransactionService : ITransactionService
    {

        public async Task<Transaction> CreateAsync(Transaction tx)
        {
            using var ctx = new AppDbContext();
            ctx.Transactions.Add(tx);
            await ctx.SaveChangesAsync();
            return tx;
        }

        public async Task DeleteAsync(int transactionId)
        {
            using var ctx = new AppDbContext();
            var tx = await ctx.Transactions.FindAsync(transactionId);
            if (tx != null)
            {
                ctx.Transactions.Remove(tx);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<List<Transaction>> GetForAccountExpensesAsync(int accountId)
        {
            using var ctx = new AppDbContext();
            return await ctx.Transactions
                             .Include(t => t.Category)
                             .Where(t => t.AccountId == accountId
                                      && t.Category.Type == TransactionType.Expense)
                             .OrderByDescending(t => t.OccurredAt)
                             .ToListAsync();
        }

        public async Task<List<Transaction>> GetForAccountIncomeAsync(int accountId)
        {
            using var ctx = new AppDbContext();
            return await ctx.Transactions
                             .Include(t => t.Category)
                             .Where(t => t.AccountId == accountId
                                      && t.Category.Type == TransactionType.Income)
                             .OrderByDescending(t => t.OccurredAt)
                             .ToListAsync();
        }

        public async Task UpdateAsync(Transaction tx)
        {
            using var ctx = new AppDbContext();
            ctx.Transactions.Update(tx);
            await ctx.SaveChangesAsync();
        }
    }
}
