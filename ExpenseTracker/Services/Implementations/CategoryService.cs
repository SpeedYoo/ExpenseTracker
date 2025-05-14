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
    internal class CategoryService : ICategoryService
    {
        public async Task<Category> CreateAsync(Category category)
        {
            using var ctx = new AppDbContext();
            ctx.Categories.Add(category);
            await ctx.SaveChangesAsync();
            return category;
        }

        public async Task DeleteAsync(int categoryId)
        {
            using var ctx = new AppDbContext();
            var tx = await ctx.Categories.FindAsync(categoryId);
            if (tx != null)
            {
                ctx.Categories.Remove(tx);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<List<Category>> GetForAccountCategoriesAsync(int accountId)
        {
            using var ctx = new AppDbContext();
            var list = await ctx.Categories
                                  .Where(c => c.AccountId == accountId)
                                  .OrderBy(c => c.Type)
                                  .ThenBy(c => c.Name)
                                  .ToListAsync();
            return list ?? new List<Category>();
        }

        public async Task<List<Category>> GetForAccountIncomeCategoriesAsync(int accountId)
        {
            using var ctx = new AppDbContext();
            var incomeCats = await ctx.Categories
                .Where(c => c.Type == TransactionType.Income)
                .OrderBy(c => c.Name)
                .ToListAsync();

            return incomeCats ?? new List<Category>();
        }

        public async Task<List<Category>> GetForAccountExpensesCategoriesAsync(int accountId)
        {
            using var ctx = new AppDbContext();
            var incomeCats = await ctx.Categories
                .Where(c => c.Type == TransactionType.Expense)
                .OrderBy(c => c.Name)
                .ToListAsync();

            return incomeCats ?? new List<Category>();
        }
    }
}
