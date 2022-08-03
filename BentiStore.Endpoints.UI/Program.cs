using Microsoft.EntityFrameworkCore;
using MiMWebsite.Service.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var cnnBenti = builder.Configuration.GetConnectionString("BentiCnn");
builder.Services.AddDbContext<BentiDbContext>(options => options.UseSqlServer(cnnBenti));
builder.Services.AddControllersWithViews();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
app.Run();
