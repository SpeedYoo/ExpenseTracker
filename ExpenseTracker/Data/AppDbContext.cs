using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=expense_db;Username=postgres;Password=balica");
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enum mapping
            modelBuilder
                .Entity<Category>()
                .Property(c => c.Type)
                .HasConversion<string>();

            // precyzja dla decimal
            modelBuilder
                .Entity<Account>()
                .Property(a => a.Balance)
                .HasColumnType("numeric(18,2)");

            modelBuilder
                .Entity<Transaction>()
                .Property(t => t.Amount)
                .HasColumnType("numeric(18,2)");

            modelBuilder.Entity<Category>()
                .HasOne(c => c.Account)
                .WithMany(a => a.Categories)
                .HasForeignKey(c => c.AccountId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
