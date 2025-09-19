using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using WebApiWithPostgreSQL.DB;
using WebApiWithPostgreSQL.DB.Entities;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new Exception("Cannot get connection string.");

const string consCorsPolicy = "CorsPolicy";

builder.Services.AddCors((c) =>
{
    c.AddPolicy(consCorsPolicy, policy =>
    {
        policy.AllowAnyHeader()
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});

builder.Services.AddDbContext<AppDbCtx>(opt => opt.UseNpgsql(connectionString));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseCors(consCorsPolicy);

app.MapGet("/users", async (AppDbCtx ctx) =>
    {
        var data = await ctx.Users.ToListAsync();
        return data;
    })
    .WithName("GetUsers")
    .Produces<List<User>>(StatusCodes.Status200OK);

app.Run();
