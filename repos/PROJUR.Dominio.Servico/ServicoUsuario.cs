using PROJUR.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJUR.Dominio.Core.Servicos;
using PROJUR.Dominio.Core.Interface;

namespace PROJUR.Dominio.Servico
{
    public class ServicoUsuario : ServicoBase<Usuario>, IServicoUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public ServicoUsuario(IRepositorioUsuario repositorioUsuario) : base(repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }
    }
}
