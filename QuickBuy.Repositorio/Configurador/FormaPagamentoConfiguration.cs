using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configurador
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(F => F.Id);

            builder.Property(F => F.Nome)
                   .IsRequired();
            
            builder.Property(F => F.Descricao)
                   .IsRequired();

        }
    }
}
