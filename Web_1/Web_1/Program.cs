using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Web_1.DataB;

namespace Web_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") + ";TrustServerCertificate=True"));

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

        private static Action<SqlServerDbContextOptionsBuilder>? Configuration(string v)
        {
            throw new NotImplementedException();
        }
    }
}
