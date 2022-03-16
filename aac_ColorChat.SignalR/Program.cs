using aac_ColorChat.SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<ColorChatHub>("/colorchat");

app.Run();
