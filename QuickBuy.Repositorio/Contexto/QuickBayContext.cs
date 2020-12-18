using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ObjetoValor;
using QuickBuy.Repositorio.Configurador;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBayContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<FormaPagamento> formaPagamentos { get; set; }


        public QuickBayContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id= 1 , Descricao="Forma Cartão",Nome="Cartao" },
                new FormaPagamento() { Id= 2 , Descricao="Forma Boleto" , Nome="Boleto"},
                new FormaPagamento() { Id= 3, Descricao = "Forma Depósito", Nome = "Deposito" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }

}
