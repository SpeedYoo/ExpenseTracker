using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data.Models;

namespace ExpenseTracker.Core.Interfaces
{
    internal interface ICategoryService
    {
        Task<List<Category>> GetForAccountCategoriesAsync(int accountId);
        Task<Category> CreateAsync(Category tx);
        Task DeleteAsync(int transactionId);
    }
}
