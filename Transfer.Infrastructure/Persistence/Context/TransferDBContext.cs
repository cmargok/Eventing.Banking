using Microsoft.EntityFrameworkCore;
using Transfer.Domain.Models;

namespace Transfer.Infrastructure.Persistence.Context
{
    public class TransferDBContext : DbContext
    {
       public DbSet<TransferLog> TransferLogs { get; set; }

        public TransferDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
