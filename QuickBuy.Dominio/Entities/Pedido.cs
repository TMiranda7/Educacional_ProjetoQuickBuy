using QuickBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Pedido : Entity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime dataCompra { get; set; }
        public DateTime dataEntrega { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int numeroEnd { get; set; }
        public virtual ICollection<ItemPedido> ItensPedidos { get;set;}
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

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
