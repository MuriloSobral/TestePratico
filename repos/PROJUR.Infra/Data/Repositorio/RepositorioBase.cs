using Microsoft.EntityFrameworkCore;
using PROJUR.Dominio.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Infra.Data.Repositorio
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {
        private readonly Contexto _contexto;
        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(TEntidade objeto)
        {
            _contexto.Set<TEntidade>().Add(objeto);
            _contexto.SaveChanges();
        }

        public void Atualizar(TEntidade objeto)
        {
            _contexto.Entry(objeto).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public TEntidade BuscarPorId(int id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> BuscarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public void Remover(TEntidade objeto)
        {
            _contexto.Set<TEntidade>().Remove(objeto);
            _contexto.SaveChanges();
        }
    }
}
