using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    class Usuario
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private ICollection<Pedido> Pedidos { get; set; }
    }
}
