using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configurador
{
    class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(Pd => Pd.Id);

            builder.Property(Pd => Pd.descricao)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(Pd => Pd.preco)
                   .IsRequired();
                   
        }
    }
}
