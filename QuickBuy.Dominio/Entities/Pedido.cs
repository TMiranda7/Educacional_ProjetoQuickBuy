using QuickBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Pedido : Entity
    {
        private int Id { get; set; }
        private int idCliente { get; set; }
        private DateTime dataCompra { get; set; }
        private DateTime dataEntrega { get; set; }
        private string Cep { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private int numeroEnd { get; set; }
        private ICollection<ItemPedido> ItensPedidos { get;set;}
        private int IdFormaPagamento { get; set; }
        private FormaPagamento FormaPagamento { get; set; }

        public override void Validate()
        {
            if (ItensPedidos.Any())
            {
                this.AdicionarCritica("warning: produto sem item");
            }

            if (string.IsNullOrEmpty(Cep))
            {
                this.AdicionarCritica("campo não pode estar vazio");
            }
        }
    }
}
