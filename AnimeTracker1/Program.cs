
// Program.cs
using Microsoft.EntityFrameworkCore;
using AnimeTracker1.Models;
using JikanDotNet;


// // Initialize JikanWrapper
// IJikan jikan = new Jikan();
// // Send request for "Cowboy Bebop" anime
// var cowboyBebop = await jikan.GetAnimeAsync(1);

// // Output -> "Cowboy Bebop"
// Console.WriteLine(cowboyBebop.Data.Titles.FirstOrDefault()?.Title);
// // Output -> "TV"
// Console.WriteLine(cowboyBebop.Data.Type);
// // Output -> "R - 17+ (violence & profanity)"
// Console.WriteLine(cowboyBebop.Data.Rating);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext with SQLite
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Create the database if it doesn't exist
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DatabaseContext>();
    context.Database.EnsureCreated();
}

app.Run();



