using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Produto : Entity
    {
        private int Id { get; set; }
        private string descricao { get; set; }
        private decimal preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(descricao))
            {
                AdicionarCritica("o item não tem descricao");
            }
            if ( preco <=0 )
            {
                AdicionarCritica("o item não tem preço definido");
            }
        }
    }
}
