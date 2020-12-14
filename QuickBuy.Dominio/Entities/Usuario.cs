using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Usuario : Entity
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private ICollection<Pedido> Pedidos { get; set; }

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
