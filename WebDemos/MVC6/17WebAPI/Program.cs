using _17WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _17WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<DACDbContext>(
                options => options.UseSqlServer("name=myCon")
                );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors((policyBuilder) => { 
            policyBuilder.WithOrigins("*").WithHeaders("*").WithMethods("*");
            });

            app.MapControllers();

            app.Run();
        }
    }
}
