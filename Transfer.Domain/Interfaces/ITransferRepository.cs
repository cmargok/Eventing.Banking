using Transfer.Domain.Models;

namespace Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        public IEnumerable<TransferLog> GetTransferLogs();
    }
}
