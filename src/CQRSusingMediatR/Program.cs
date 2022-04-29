using CQRSusingMediatR.CQRS.Queries.Handlers;
using CQRSusingMediatR.Data;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// services.AddMediatR(assemby)
//any class in the assemby where the handlers live! 
//important word here is 'handlers'! 'any class' as mediatr is interested in the assembly only

//builder.Services.AddMediatR(typeof(Startup).Assembly); // if declared in Startup.cs
//builder.Services.AddMediatR(typeof(Program).Assembly); // if declared in Program.cs
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly()); // universal
builder.Services.AddMediatR(typeof(Program).GetTypeInfo().Assembly);


builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<GetCustomersQueryHandler>();

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

app.MapControllers();

app.Run();
