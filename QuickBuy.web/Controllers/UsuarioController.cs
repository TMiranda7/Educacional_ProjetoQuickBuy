using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contrato;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
               return Ok();
            }
            catch(Exception ex)
            {
               return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                _usuarioRepository.Adicionar(usuario);
                return Created( "api/usuario" , usuario);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
