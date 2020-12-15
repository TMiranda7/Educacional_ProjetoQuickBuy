using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Usuario : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                AdicionarCritica(" não tem Nome");
            }

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica(" não tem Email");
            }
        }
    }


}
