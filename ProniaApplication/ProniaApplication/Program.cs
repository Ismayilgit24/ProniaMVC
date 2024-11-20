using Microsoft.EntityFrameworkCore;
using ProniaApplication.DAL;

namespace ProniaApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBContext>(
                opt => opt.UseSqlServer("server=DESKTOP-NKLQH71\\SQLEXPRESS;database=ProniaBP217DB;trusted_connection=true;integrated security=true;TrustServerCertificate=true")

                );

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}"
                );

            app.Run();
        }
    }
}
