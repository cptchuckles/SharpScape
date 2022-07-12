using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.StaticFiles;
using SharpScape.Api.Services;
using SharpScape.Api.Data;

using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

#if !DEBUG
Environment.SetEnvironmentVariable("DATABASE_CONNECTION", "RemoteTesting");
#endif

// Add services to the container.
if (Environment.GetEnvironmentVariable("DATABASE_CONNECTION") == "RemoteTesting")
{
    Console.WriteLine("USING REMOTE TESTING CONNECTION");
    builder.Services.AddDbContext<AppDbContext, PgDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("RemoteTestingConnection")));
}

else
{
    Console.WriteLine("USING SQLITE TESTING CONNECTION");
    builder.Services.AddDbContext<AppDbContext, SqliteDbContext>(options => {
        options.EnableSensitiveDataLogging();
        options.UseSqlite(builder.Configuration.GetConnectionString("LocalDevelopmentConnection"));
    });
}

builder.Services.AddSingleton<RsaKeyProvider>();

builder.Services.AddScoped<Crypto>();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Copy-pastad a bunch of shit (well i typed it) to get Bearer authentication working in Swagger.
builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "You must type the word \"Bearer\", followed by a space, and then paste your JWT"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                    Reference = new OpenApiReference {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer" }},
            
            new string[] {}
        }
    });
});

builder.Services.AddRazorPages();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => {
        var rsaPublicKey = System.Security.Cryptography.RSA.Create();
     rsaPublicKey.ImportFromPem(File.ReadAllText(builder.Configuration["Jwt:RSA:PublicKey"]));

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateLifetime = true,

            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],

            ValidateIssuerSigningKey = true,
            ValidAlgorithms = builder.Configuration.GetValue<string[]>("Jwt:Algorithms"),
            IssuerSigningKey = new RsaSecurityKey(rsaPublicKey)
        };
    });

builder.Services.Configure<StaticFileOptions>(options=>
{
    var provider = new FileExtensionContentTypeProvider();
    provider.Mappings.Add(".pck","application/octet-stream");
    options.ContentTypeProvider = provider;
});

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddCors(options => options.AddDefaultPolicy(policy => {
        policy.AllowAnyOrigin();
        policy.WithMethods(new[] {"GET"});
    }));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();

    app.UseCors();
}
else
{
    app.UseHttpsRedirection();
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
