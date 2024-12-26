namespace _04ActionMethodReturnTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            //app.MapControllerRoute(
            //    name:"deafult",
            //    pattern:"{controller=Home}/{action=Index}/{id?}/{un?}/{pwd?}"
            //    );
            app.MapControllerRoute(
               name: "deafult",
               pattern: "{controller=Home}/{action=Index}/{id?}"
               );

            app.Run();
        }
    }
}
