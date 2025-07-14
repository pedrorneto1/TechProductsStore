using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReactWithASP.Server.Database;
using System.Diagnostics.Metrics;
using System.Security.Claims;
using Tech_Products.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(IdentityConstants.ApplicationScheme)
    .AddCookie(IdentityConstants.ApplicationScheme)
    .AddBearerToken(IdentityConstants.BearerScheme);
builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<UserDbContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer("Server=DESKTOP-B9PGF75;Database=IdentityDB;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlServer("Server=DESKTOP-B9PGF75;Database=StoreDB;Trusted_Connection=True;TrustServerCertificate=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // app.MapOpenApi();
    // app.ApplyMigrations();
}

app.MapGet("users/me", async (ClaimsPrincipal claims, UserDbContext context) =>
{
    string userId = claims.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
    
    return await context.Users.FindAsync(userId);
})
    .RequireAuthorization();

app.UseHttpsRedirection();

app.MapIdentityApi<User>();

app.UseAuthorization();

app.MapControllers();

app.Run();
