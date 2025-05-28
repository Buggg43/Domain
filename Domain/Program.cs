using Domain.Services;

namespace Domain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<IProductServices, ProductServices>();

            builder.Services.AddControllers();

            // Register the ProductServices
            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
