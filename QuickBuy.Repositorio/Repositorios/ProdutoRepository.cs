using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.Contrato;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class ProdutoRepository : BaseRepository<Produto> , IProdutoRepository
    {
        public ProdutoRepository(QuickBayContext quickBayContext) : base(quickBayContext)
        {

        }
    }
}
