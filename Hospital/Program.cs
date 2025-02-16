
using Hospital.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital
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
                .UseSqlServer("Server=DESKTOP-JMDSV2Q\\SQLEXPRESS;Database=Hospital;Trusted_Connection=true;TrustServerCertificate=true"));

            var app = builder.Build();



            app.MapOpenApi();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
