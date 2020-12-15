using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configurador
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(U => U.Id);

            builder
                .Property(U => U.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(U => U.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(U => U.Senha)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(U => U.Pedidos)
                .WithOne(U => U.Usuario);
        }
    }
}
