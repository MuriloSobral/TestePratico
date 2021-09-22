using AutoMapper;
using PROJUR.Aplicacao.DTOs;
using PROJUR.Aplicacao.Interface;
using PROJUR.Dominio.Core.Servicos;
using PROJUR.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Aplicacao.Servico
{
    public class AplicacaoServicoUsuario : IAplicacaoServicoUsuario
    {
        private readonly IServicoUsuario _servicoUsuario;
        private readonly IMapper _mapper;
        public AplicacaoServicoUsuario(IServicoUsuario servicoUsuario, IMapper mapper)
        {
            _servicoUsuario = servicoUsuario;
            _mapper = mapper;
        }
        public void Adicionar(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            _servicoUsuario.Adicionar(usuario);
        }

        public void Atualizar(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            _servicoUsuario.Atualizar(usuario);
        }

        public UsuarioDTO BuscarPorId(int id)
        {
            var usuario = _servicoUsuario.BuscarPorId(id);
            return _mapper.Map<UsuarioDTO>(usuario);
        }

        public IEnumerable<UsuarioDTO> BuscarTodos()
        {
            var listaDeUsuarios = _servicoUsuario.BuscarTodos();
            return _mapper.Map<List<UsuarioDTO>>(listaDeUsuarios);
        }

        public void Remover(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            _servicoUsuario.Remover(usuario);
        }
    }
}
