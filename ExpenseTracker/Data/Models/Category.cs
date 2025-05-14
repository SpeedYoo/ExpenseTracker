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
    [Table("categories")]
    public class Category
    {
        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Required, MaxLength(100)]
        [Column("name")]
        public required string Name { get; set; }

        [Required]
        [Column("type")]
        public TransactionType Type { get; set; }

        [Required]
        [ForeignKey(nameof(Account))]
        [Column("account_id")]
        public int AccountId { get; set; }

        public Account? Account { get; set; }

        public ICollection<Transaction>? Transactions { get; set; }
    }
}
