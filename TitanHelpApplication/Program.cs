using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TitanHelpApplication.Data;
//using TitanHelpApplication.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TitanHelpApplicationContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TitanHelpApplicationContext") ?? throw new InvalidOperationException("Connection string 'TitanHelpApplicationContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<TicketDbContext>(options =>
//    options.UseSqlite(connectionString));

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();





