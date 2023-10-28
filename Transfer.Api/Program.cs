
using EventBusLibrary.Core.Bus;
using EventBusLibrary.IoC;
using Transfer.Api.IoC;
using Transfer.Domain.EventHandlers;
using Transfer.Domain.Events;

var builder = WebApplication.CreateBuilder(args);




//register Event services
builder.Services.AddEventBus(builder.Configuration);

DependencyContainerThisApi.RegisterTransferServices(builder.Services, builder.Configuration);
// Add services to the container.
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
        builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyHeader()
        );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


var eventBus = app.Services.GetRequiredService<IEventBus>();

eventBus.Subscribe<TransferCreateEvent, TransferEventHandler>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
