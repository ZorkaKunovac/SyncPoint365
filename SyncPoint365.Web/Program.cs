using SyncPoint365.BLL.Services.Countries;
using SyncPoint365.BLL.Services.Ocjene;
using SyncPoint365.BLL.Services.Ucenici;

namespace SyncPoint365.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICountriesService, CountriesService>();
            builder.Services.AddScoped<IUceniciService, UceniciService>();
            builder.Services.AddScoped<IOcjeneService, OcjeneService>();


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
        }
    }
}