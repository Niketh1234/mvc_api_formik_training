using RestApiDemo.Repositories;

namespace RestApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();
            builder.Services.AddControllers();
            builder.Services.AddSingleton<IStoreListRepository,StoreListRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapControllers();
            app.Run();
        }
    }
}
