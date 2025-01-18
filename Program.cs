using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlogTest3.Data;
using BlogTest3.Areas.Identity.Data;
using BlogTest3.Controllers;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BlogTest3ContextConnection") ?? throw new InvalidOperationException("Connection string 'BlogTest3ContextConnection' not found.");

builder.Services.AddDbContext<BlogTest3Context>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<BlogTest3User>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<BlogTest3Context>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
    string.Join("\n", endpointSources.SelectMany(source => source.Endpoints)));

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

