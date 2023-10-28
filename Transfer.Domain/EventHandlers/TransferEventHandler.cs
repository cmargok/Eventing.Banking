using EventBusLibrary.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer.Domain.Events;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Models;

namespace Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreateEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }


        public Task Handle(TransferCreateEvent @event)
        {
            var transaction = new TransferLog
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmmount = @event.Amount
            };

            _transferRepository.AddTransferLog(transaction);

            return Task.CompletedTask;
        }
    }
} 
