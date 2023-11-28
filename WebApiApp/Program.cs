
using Microsoft.EntityFrameworkCore;
using WebApiApp.Models;

namespace WebApiApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(
                options => 
                    options.AddDefaultPolicy(policyoption=>
                            policyoption.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin())
                    );
            
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CompanyEntity>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors();
            app.UseAuthorization();

            
            app.MapControllers();

            app.Run();
        }
    }
}