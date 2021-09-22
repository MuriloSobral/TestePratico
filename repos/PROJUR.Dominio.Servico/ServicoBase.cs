using PROJUR.Dominio.Core.Interface;
using PROJUR.Dominio.Core.Servicos;
using System.Collections.Generic;

namespace PROJUR.Dominio.Servico
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : class
    {
        private readonly IRepositorioBase<TEntidade> _repositorio;
        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }
        public void Adicionar(TEntidade objeto)
        {
            _repositorio.Adicionar(objeto);
        }

        public void Atualizar(TEntidade objeto)
        {
            _repositorio.Atualizar(objeto);
        }

        public TEntidade BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public IEnumerable<TEntidade> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public void Remover(TEntidade objeto)
        {
            _repositorio.Remover(objeto);
        }
    }
}
