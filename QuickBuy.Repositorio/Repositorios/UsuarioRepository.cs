using QuickBuy.Dominio.Contrato;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepository : BaseRepository<Usuario> , IUsuarioRepository
    {
        public UsuarioRepository(QuickBayContext quickBayContext) : base(quickBayContext)
        {

        }
    }
}
