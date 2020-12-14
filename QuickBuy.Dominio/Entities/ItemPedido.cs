using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    class ItemPedido : Entity
    {
        private int Id { get; set; }
        private int idProduto { get; set; }
        private int Qntd { get; set; }

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
