using Microsoft.EntityFrameworkCore;

namespace simulador_de_bolsa_valores_API.Models;

public class StockExchangeContext : DbContext{
    
    public StockExchangeContext(
        DbContextOptions<StockExchangeContext> options
    ): base(options){}

    public StockExchangeContext(){}


    protected override void OnModelCreating(ModelBuilder modelBuilder){
        // definir os tamanhos de caracteres para cada string
        modelBuilder.Entity<Client>()
            .HasKey(c => c.Account);


        modelBuilder.Entity<Order>()
            .HasKey(c => c.Order_id);


        // inserir alguns usuarios na tabela
        //modelBuilder.Entity<Client>().HasData(
        //    new Client { Account = "0002024" , Name = "Julia"},
        //    new Client { Account = "0002025" , Name = "Pedro"},
        //    new Client { Account = "0002026" , Name = "Vitor"}
        //);
    }

    public virtual DbSet<Order> Orders{ get; set; } = null!;
    public virtual DbSet<Client> Clients{ get; set; } = null!;
}
