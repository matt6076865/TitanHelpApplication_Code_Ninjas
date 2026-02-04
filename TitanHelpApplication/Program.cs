using Microsoft.EntityFrameworkCore;
using TitanHelpApplication.Data;
using TitanHelpApplication.Services;
using TitanHelpApplication.Models;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURATION ---
// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                      ?? "Data Source=TitanHelp.db";

// --- 2. SERVICE REGISTRATION (Must be BEFORE builder.Build) ---
builder.Services.AddControllersWithViews();

// Register the Database
builder.Services.AddDbContext<TicketDbContext>(options =>
    options.UseSqlite(connectionString));

// Register your Service (The Brain)
builder.Services.AddScoped<ITicketService, TicketService>();

// --- 3. BUILD THE APP ---
var app = builder.Build();

// --- 4. MIDDLEWARE (The Request Pipeline) ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// --- 5. ROUTING ---
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ticket}/{action=Index}/{id?}");

app.Run();


