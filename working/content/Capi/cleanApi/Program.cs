
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddInfrastructuresServices(builder.Configuration);

var app = builder.Build();
app.UseApiServises();

app.Run();
