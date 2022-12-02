using Microsoft.EntityFrameworkCore;
using Team2BucHunt.Services;

#region Builder setup

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Sets the default connection string to be equal to the default connection string set in app settings
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//adds a scoped service for the repo
builder.Services.AddScoped<IBucHuntRepository, DbBucHuntRepository>();
//applies the db context service
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

var app = builder.Build();

#endregion

#region Configure pipeline and middleware

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#endregion

app.Run();
