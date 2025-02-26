using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Domain.Models;
using Orion.Extensions;
using Orion.Infrastructure.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add session services
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout///////
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.ConfigureRouter();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("OrionDB")));

// Add Identity services
builder.Services.AddIdentity<User, IdentityRole<int>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureMapper();
builder.Services.AddControllersWithViews();
builder.Services.ConfigureHttpContext();
builder.Services.ConfigureInfrastructure();
builder.Services.ConfigureApiVersions();
builder.Services.ConfigureWebApi(builder.Configuration);
builder.Services.ConfigureEmailSender(builder.Configuration);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Set up default file to serve index.html
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "index.html" }
});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Use session
app.UseSession();

app.MapRazorPages();
app.MapControllers();

app.Run();
