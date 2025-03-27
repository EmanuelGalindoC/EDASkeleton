using EdaSkeleton.Service;
using EdaSkeleton.EventHandler;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddSingleton<OrderEventHandler>();

var app = builder.Build();

app.MapControllers();
app.Run();
