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
            get 
            { 
                return !_mensagem.Any(); 
            }
        }

        protected List<string> MensagemValidacao
        {
            get
            {
                return _mensagem ??( _mensagem = new List<string>());
            }
        }

        protected void LimparValidacao()
        {
            _mensagem.Clear();
        }

        public void AdicionarCritica (string msg )
        {
            MensagemValidacao.Add(msg);
        }
    }
}
