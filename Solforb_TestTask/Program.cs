using Solforb_TestTask.BL.Implementations;
using Solforb_TestTask.BL.Interfaces;
using Solforb_TestTask.DAL.Implementations;
using Solforb_TestTask.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IOrderItemBL, OrderItemBL>();
builder.Services.AddSingleton<IOrderItemDAL, OrderItemDAL>();

builder.Services.AddSingleton<IProviderBL, ProviderBL>();
builder.Services.AddSingleton<IProviderDAL, ProviderDAL>();

builder.Services.AddSingleton<IOrderBL, OrderBL>();
builder.Services.AddSingleton<IOrderDAL, OrderDAL>();

builder.Services.AddMemoryCache();

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
