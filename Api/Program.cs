using SharpScape.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "RemoteTesting")
{
    builder.Services.AddDbContext<DbContext, PgDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("RemoteTestingConnection")));
}
else
{
    builder.Services.AddDbContext<DbContext, SqliteDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("LocalDevelopmentConnection")));
}

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
