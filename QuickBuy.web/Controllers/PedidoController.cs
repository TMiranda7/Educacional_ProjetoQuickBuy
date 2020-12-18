using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contrato;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository pedidoRepository;
        public PedidoController(IPedidoRepository _pedidoRepository)
        {
            pedidoRepository = _pedidoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pedido pedido)
        {
            try
            {
                pedidoRepository.Adicionar(pedido);
                return Created("api/pedido", pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}