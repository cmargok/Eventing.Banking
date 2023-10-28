using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Transfer.Domain.Models
{
    public class TransferLog
    {
        [Key]
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal TransferAmmount { get; set; }
    }
}
