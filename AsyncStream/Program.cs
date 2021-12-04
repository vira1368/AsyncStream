var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddJsonOptions(jsonOptions => { jsonOptions.JsonSerializerOptions.WriteIndented = true; });

var app = builder.Build();

app.MapControllers();

app.Run();
