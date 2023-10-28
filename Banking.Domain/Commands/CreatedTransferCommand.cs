namespace Banking.Domain.Commands
{
    public class CreatedTransferCommand : TransferCommand
    {

        public CreatedTransferCommand(int from, int to, decimal ammount)
        {
            From = from;
            To = to;
            Amount = ammount;
        }
    }

}
