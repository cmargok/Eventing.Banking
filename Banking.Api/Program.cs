using Banking.Application.IoC;
using EventBusLibrary.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
DependencyContainerThisApi.RegisterBankingServices(builder.Services, builder.Configuration);

//register Event services
builder.Services.RegisterServices(builder.Configuration);

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
