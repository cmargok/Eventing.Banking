using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Models;
using Transfer.Infrastructure.Persistence.Context;

namespace Transfer.Infrastructure.Persistence.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDBContext _dbContext;
        public TransferRepository(TransferDBContext dbContext)
        {
            _dbContext = dbContext;
        }
       

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            var logs = _dbContext.TransferLogs;

            return logs;
        }
    }
}
