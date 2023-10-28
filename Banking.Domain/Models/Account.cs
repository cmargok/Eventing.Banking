using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking.Domain.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string AccountType { get; set; } = string.Empty;

        [Column(TypeName = "decimal(5, 2)")]
        public decimal AccountBalance { get; set; }

    }
}
