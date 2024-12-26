namespace _01MVCBasic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            //flow of your application by 
            //writting Middleware components here....

            //app.MapGet("/", () => "Hello World!");
            app.Use(async(context,next) => {
                await context.Response.WriteAsync("Wel-come to MVC Core 6.0!");
                await next(context);
            });
            app.Run(async (context) => {
                await context.Response.WriteAsync("\nI am Mugdha your trainer for this module");
            });

            app.Run();
        }
    }
}
