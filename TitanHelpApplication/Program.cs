using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TitanHelpApplication.Data;
using TitanHelpApplication.Repositories;


var builder = WebApplication.CreateBuilder(args);
// Configure the database context to use SQLite
// This tells the app: "When anyone asks for TicketDbContext, give them this SQLite connection."
builder.Services.AddDbContext<TicketDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=TitanHelp.db")); //may have to del later
//?? throw new InvalidOperationException("Connection string 'TitanHelpApplicationContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register the Repository (Data Layer)
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
//awaiting SereviceLayer builder.Services.AddScoped<ITicketService, TicketService>();

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

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();





