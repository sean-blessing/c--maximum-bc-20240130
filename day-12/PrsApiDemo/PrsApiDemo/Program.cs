using Microsoft.EntityFrameworkCore;
using PrsApiDemo.models;

namespace PrsApiDemo {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<PrsDbContext>(
                // lambda
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("PRSConnectionString"))
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
