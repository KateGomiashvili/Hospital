
using Microsoft.EntityFrameworkCore;
using Movies.Repository.Data;

namespace Movies.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            builder.Services
                .AddDbContext<ApplicationDbContext>(options => options
                .UseSqlServer("Server=DESKTOP-JMDSV2Q\\SQLEXPRESS;Database=Movies;Trusted_Connection=true;TrustServerCertificate=true"));

            var app = builder.Build();



            app.MapOpenApi();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
