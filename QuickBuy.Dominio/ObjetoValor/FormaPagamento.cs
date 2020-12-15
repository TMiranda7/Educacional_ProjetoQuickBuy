using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }

        public bool Eboleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool ECartao
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Cartao; }
        }
        public bool EDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool ENaoIdentificada
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoIdentificada; }
        }

    }
}
