using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data.Models;

namespace ExpenseTracker.Core.Interfaces
{
    internal interface ITransactionService
    {
        Task<List<Transaction>> GetForAccountExpensesAsync(int accountId);
        Task<List<Transaction>> GetForAccountIncomeAsync(int accountId);
        Task<Transaction> CreateAsync(Transaction tx);
        Task UpdateAsync(Transaction tx);
        Task DeleteAsync(int transactionId);
    }
}
