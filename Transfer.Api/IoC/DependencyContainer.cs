using EventBusLibrary.Core.Bus;
using Microsoft.EntityFrameworkCore;
using Transfer.Application.Interfaces;
using Transfer.Application.Services;
using Transfer.Domain.EventHandlers;
using Transfer.Domain.Events;
using Transfer.Domain.Interfaces;
using Transfer.Infrastructure.Persistence.Context;
using Transfer.Infrastructure.Persistence.Repositories;

namespace Transfer.Api.IoC
{
    public class DependencyContainerThisApi
    {
        public static void RegisterTransferServices(IServiceCollection services, IConfiguration configuration)
        {

            //applications services
            services.AddTransient<ITransferService, TransferService>();


            //infrastructure 
            services.AddTransient<ITransferRepository, TransferRepository>();

            services.AddDbContext<TransferDBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("TransferDb")));

            services.AddTransient<IEventHandler<TransferCreateEvent>, TransferEventHandler>();

            services.AddTransient<TransferEventHandler>();
        }

    }
}
