using MiMWebsite.Service.Common;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var cnnString = builder.Configuration.GetConnectionString("BentiCnn");
builder.Services.AddDbContext<BentiDbContext>(options => options.UseSqlServer(cnnString));
var app = builder.Build();


app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
app.Run();
 