using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configurador
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(P => P.Id);

            builder.Property(P => P.Cep)
                   .IsRequired();

            builder.Property(P => P.Cidade)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(P => P.Bairro)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(P => P.Estado)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(P => P.numeroEnd)
                   .IsRequired();

            //builder.HasOne(P => P.FormaPagamento).WithMany(P => P.Id)
        }
    }
}
