namespace _02DefaultController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            //localhost:portno/Home/Index - /controller/actionMethod
            //https://localhost:44346/Home/Index
            //app.MapDefaultControllerRoute();
            //https://localhost:44346/Home/Index/55:Optional(?)
            //https://localhost:44346/Admin/Index/55:Optional(?)
            //Conventional Ruoting
            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
