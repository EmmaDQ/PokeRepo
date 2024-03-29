using Microsoft.EntityFrameworkCore;
using PokeRepo.Api;
using PokeRepo.Database;
using PokeRepo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

string? connectionString = builder.Configuration.GetConnectionString("DbConnection");
builder.Services.AddDbContext<PokeDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IPokkeRepo, PokkeRepo>();
builder.Services.AddScoped<ApiCaller>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
