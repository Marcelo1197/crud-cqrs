using DemoLibrary;
using DemoLibrary.DataAccess;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Inject DataAccess to our app
builder.Services.AddSingleton<IDataAccess, DemoDataAccess>();
// Inject MediatR reference of DemoLibrary project in our BlazorUI app
builder.Services.AddMediatR(typeof(DemoLibraryMediatREntryPoint).Assembly);

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
