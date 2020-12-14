using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public abstract class Entity
    {
        public abstract void Validate();
        public List<string> _mensagem { get; set; }

        public bool EValido
        {
            get { return _mensagem.Any(); }
        }

        protected List<string> Mensagem
        {
            get { return _mensagem ??( _mensagem = new List<string>()); }
        }

        public void AdicionarCritica (string msg )
        {
            Mensagem.Add(msg);
        }


    }
}
