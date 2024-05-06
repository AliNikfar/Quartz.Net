using NormalImplement;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<ExampleHostedService>();
builder.Services.AddHostedService<ExampleHostedService1>();
builder.Services.AddHostedService<ExampleHostedService2>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();



