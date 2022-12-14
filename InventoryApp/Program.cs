using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Shared.Database;
using Shared.ModelDTO;
using Shared.Models;
using Shared.Services;
using Shared.IServices;


var builder = WebApplication.CreateBuilder(args);
//var builder = new ConfigurationBuilder();
// Add services to the container.
builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddDbContext<NV_DBContext>
    (options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("INVAppConnection"))
    );
// builder.Services.AddSingleton<IService<Vendor>, VendorService>();

var app = builder.Build();

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

app.Run();
