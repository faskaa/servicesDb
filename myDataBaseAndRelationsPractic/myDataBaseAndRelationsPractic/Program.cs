using Microsoft.EntityFrameworkCore;
using myDataBaseAndRelationsPractic.DAL;

namespace myDataBaseAndRelationsPractic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ServicesDBContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            
            var app = builder.Build();
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "{controller}/{action}");
            //    endpoints.MapControllerRoute("default", "{controller=home}/{action=login}");
            //});

            app.MapControllerRoute("default", "{controller=service}/{action=detail}");

            app.UseStaticFiles();

            app.Run();
        }
    }
}