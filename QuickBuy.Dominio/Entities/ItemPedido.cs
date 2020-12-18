using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Dominio.Entities
{
    public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int Qntd { get; set; }

        public override void Validate()
        {
            if( Qntd == 0)
            {
                this.AdicionarCritica("o item não pode estar vazio");
            }
        }
    }
}
