using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Contrato
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity obterId(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
        void Remover(TEntity entity);
        void Atualizar(TEntity entity);
    }
}
