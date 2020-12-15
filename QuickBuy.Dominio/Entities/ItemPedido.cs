using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int idProduto { get; set; }
        public int Qntd { get; set; }

        public override void Validate()
        {
            if( Qntd == 0)
            {
                this.AdicionarCritica("o item não pode estar vazio");
            }
            if (idProduto == 0)
            {
                this.AdicionarCritica("o item não pode estar vazio");
            }
        }
    }
}
