using _09ActionResultFilters.Filters;

namespace _09ActionResultFilters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<LoggingActionFilter>();
            builder.Services.AddScoped<DynamicLayoutFilter>();

            var app = builder.Build();

            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
