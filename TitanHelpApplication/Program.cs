using Microsoft.EntityFrameworkCore;
using TitanHelpApplication.Data;
using TitanHelpApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURATION & SERVICE REGISTRATION ---

// Register controllers and views
builder.Services.AddControllersWithViews();

// Register the Database
builder.Services.AddDbContext<TicketDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ??
        "Data Source=TitanHelp.db"));

// Register your Service (The Brain - Dependency Injection)
builder.Services.AddScoped<ITicketService, TicketService>();

// --- 2. BUILD THE APP ---
var app = builder.Build();

// --- 3. MIDDLEWARE (The Request Pipeline) ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// --- 4. ROUTING ---
// Updated default controller to 'Tickets' instead of 'Ticket'
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tickets}/{action=Index}/{id?}");

app.Run();