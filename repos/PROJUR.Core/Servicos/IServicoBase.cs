using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Dominio.Core.Servicos
{
    public interface IServicoBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade objeto);
        void Atualizar(TEntidade objeto);
        void Remover(TEntidade objeto);
        IEnumerable<TEntidade> BuscarTodos();
        TEntidade BuscarPorId(int id);
    }
}
