using AirFlight2.Service.Mapping;
using AirFlight2.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//https://localhost:7099/api/AirPort/GetAllAirPort
//builder.Services.AddHttpClient<CountryApiService>(opt => 
//{
//    opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);
//});
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddHttpClient<CountryApiService>();
builder.Services.AddHttpClient<AirPortApiService>();
builder.Services.AddHttpClient<SearchApiService>();  
 
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
    pattern: "{controller=Flight}/{action=Index}/{id?}");

app.Run();
