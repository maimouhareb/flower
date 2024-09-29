
using System.IO;
using System.Buffers;
using Microsoft.EntityFrameworkCore; 

using lab1.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();
builder.Services.AddDbContext<Datacontext>(options=>{
options.UseSqlServer(builder.Configuration[
 "ConnectionStrings:DefaultConnection"
]);
//   عشان اوصل لاتصال غير مباشر  عرفت داتا من خلال متغير اوبشن//
//ا الاعددادات موجودة ب ملف  ديفلتsql في ملف اسمه
options.EnableSensitiveDataLogging(true);
}

);
builder.Services.AddControllersWithViews();

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
