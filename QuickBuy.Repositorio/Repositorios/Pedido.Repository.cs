using QuickBuy.Dominio.Contrato;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(QuickBayContext quickBayContext) : base(quickBayContext)
        {

        }
    }
}
