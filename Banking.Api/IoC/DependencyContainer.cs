using Banking.Application.interfaces;
using Banking.Application.services;
using Banking.Domain.Interfaces;
using Banking.Infrastructure.Persistence.Context;
using Banking.Infrastructure.Persistence.Repositories;
using EventBusLibrary.Bus;
using EventBusLibrary.Core.Bus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.Application.IoC
{
    public class DependencyContainerThisApi
    {
        public static void RegisterBankingServices(IServiceCollection services, IConfiguration configuration) 
        {

            //applications services
            services.AddTransient<IAccountService, AccountService>();


            //infrastructure 
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddDbContext<BankingDBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("BankingDB")));


            //rabbitmq
            services.AddTransient<IEventBus, RabbitMQBus>();

            services.Configure<RabbitMQSettings>(configuration.GetSection("RabbitMQSettings"));

            services.AddMediatR(config =>
           config.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        }
     
    }
}
