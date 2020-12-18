using QuickBuy.Dominio.Contrato;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly QuickBayContext QuickBayContext;
        public BaseRepository(QuickBayContext quickBayContext)
        {
            QuickBayContext = quickBayContext;
        }
        public void Adicionar(TEntity entity)
        {
            QuickBayContext.Set<TEntity>().Add(entity);
            QuickBayContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBayContext.Set<TEntity>().Update(entity);
            QuickBayContext.SaveChanges();
        }

        public void Dispose()
        {
            QuickBayContext.Dispose();
        }

        public TEntity obterId(TEntity entity)
        {
            return QuickBayContext.Set<TEntity>().Find(entity);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBayContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickBayContext.Set<TEntity>().Remove(entity);
            QuickBayContext.SaveChanges();
        }
    }
}
