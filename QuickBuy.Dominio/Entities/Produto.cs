using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Produto : Entity
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
           /* if (string.IsNullOrEmpty(descricao))
            {
                AdicionarCritica("o item não tem descricao");
            }
            if ( preco <=0 )
            {
                AdicionarCritica("o item não tem preço definido");
            }
            */
        }
    }
}
