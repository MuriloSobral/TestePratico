using PROJUR.Aplicacao.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Aplicacao.Interface
{
    public interface IAplicacaoServicoUsuario
    {
        void Adicionar(UsuarioDTO usuarioDTO);
        void Atualizar(UsuarioDTO usuarioDTO);
        void Remover(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> BuscarTodos();
        UsuarioDTO BuscarPorId(int id);
    }
}
