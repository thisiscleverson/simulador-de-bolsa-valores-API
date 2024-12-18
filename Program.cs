using Microsoft.EntityFrameworkCore;
using simulador_de_bolsa_valores_API.DAL;
using simulador_de_bolsa_valores_API.Models;

namespace simulador_de_bolsa_valores_API;

public class Program{
    public static void Main(string[] args){
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        
        var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");

        builder.Services.AddDbContext<StockExchangeContext>(options =>{
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });

        builder.Services.AddScoped<IOrderRepository, OrderRepository>();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.MapControllers();
        
        app.Run();
    }
}


