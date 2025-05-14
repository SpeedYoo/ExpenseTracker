using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Data.Models
{
    [Table("transactions")]
    public class Transaction
    {
        [Key]
        [Column("transaction_id")]
        public int TransactionId { get; set; }

        [Required]
        [ForeignKey(nameof(Account))]
        [Column("account_id")]
        public int AccountId { get; set; }
        public  Account Account { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        [Column("category_id")]
        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        [Required]
        [Column("amount", TypeName = "numeric(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [Column("occurred_at")]
        public DateTime OccurredAt { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
