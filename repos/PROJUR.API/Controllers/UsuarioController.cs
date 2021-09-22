using Microsoft.AspNetCore.Mvc;
using PROJUR.Aplicacao.DTOs;
using PROJUR.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJUR.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IAplicacaoServicoUsuario _aplicacaoServicoUsuario;
        public UsuarioController(IAplicacaoServicoUsuario aplicacaoServicoUsuario)
        {
            _aplicacaoServicoUsuario = aplicacaoServicoUsuario;
        }

        [HttpGet]
        [Route("BuscarTodos")]
        public ActionResult<IEnumerable<UsuarioDTO>> BuscarTodos()
        {
            return Ok(_aplicacaoServicoUsuario.BuscarTodos());
        }
        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Adicionar([FromBody] UsuarioDTO usuarioDTO)
        {
            _aplicacaoServicoUsuario.Adicionar(usuarioDTO);
            return Ok();
        }
        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Atualizar([FromBody] UsuarioDTO usuarioDTO)
        {
            _aplicacaoServicoUsuario.Atualizar(usuarioDTO);
            return Ok();
        }
        [HttpDelete]
        [Route("Remover")]
        public ActionResult Remover([FromBody] UsuarioDTO usuarioDTO)
        {
            _aplicacaoServicoUsuario.Remover(usuarioDTO);
            return Ok();
        }
    }
}
