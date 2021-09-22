using PROJUR.Dominio.Core.Interface;
using PROJUR.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Infra.Data.Repositorio
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        private readonly Contexto _contexto;
        public RepositorioUsuario(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
