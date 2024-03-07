using BmdbWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BmdbWebApi {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            string connStr = builder.Configuration.GetConnectionString("BmdbConnectionString");

            builder.Services.AddDbContext<BmdbDbContext>(
                // lambda
                options => options.UseSqlServer(connStr)
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
