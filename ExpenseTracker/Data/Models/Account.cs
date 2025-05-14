using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExpenseTracker.Data.Models
{
    public enum TransactionType
    {
        Income,
        Expense
    }

    [Table("accounts")]
    public class Account
    {
        [Key]
        [Column("account_id")]
        public int AccountId { get; set; }

        [Required, MaxLength(100)]
        [Column("name")]
        public required string Name { get; set; }

        [Column("description")]
        public required string Description { get; set; }

        [Required]
        [Column("balance", TypeName = "numeric(18,2)")]
        public decimal Balance { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public  ICollection<Transaction>? Transactions { get; set; }

        public ICollection<Category>? Categories { get; set; }
    }
}
