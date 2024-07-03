using JobLib.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvc();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Log.Logger = new LoggerConfiguration()
//    .WriteTo.File("logs/log.log",
//        rollingInterval: RollingInterval.Day,
//        rollOnFileSizeLimit: true)
//    .CreateLogger();
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();
//https://code-maze.com/csharp-configure-rolling-file-logging-with-serilog/
//https://github.com/serilog/serilog-settings-configuration

//job
//builder.Services.AddHostedService<DemoTask>();

//logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
//setup Serilog
builder.Services.AddSerilog();

//session
builder.Services.AddStackExchangeRedisCache(option =>
option.Configuration = builder.Configuration.GetConnectionString("RedisSession"));//DistributedSession
builder.Services.AddSession();

builder.Services.AddControllers().AddJsonStreamer();

var app = builder.Build();

//Serilog
app.UseSerilogRequestLogging();

app.UseSession();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllers();

app.Run();

//¸Ñtoken