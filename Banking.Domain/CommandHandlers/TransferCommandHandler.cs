using Banking.Domain.Commands;
using Banking.Domain.Events;
using EventBusLibrary.Core.Bus;
using MediatR;

namespace Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreatedTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task<bool> Handle(CreatedTransferCommand request, CancellationToken cancellationToken)
        {
            //logica para publicar el mensaje
            var evento = new TransferCreateEvent(request.From, request.To, request.Amount);

            _eventBus.Publish(evento);


            return Task.FromResult(true);
        }
    }
}
