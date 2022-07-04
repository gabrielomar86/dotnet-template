using System;
using System.Linq;
using System.Linq.Expressions;
using GuayaswestSample.core.interfaces.contratos;
using Microsoft.EntityFrameworkCore;

namespace GuayaswestSample.infrastructure.data
{
    public class RepositorioGenerico<TEntidad> : IRepositorioGenerico<TEntidad> where TEntidad : class
    {
        protected readonly GuayaswestSampleContexto _GuayaswestSampleContexto;

        public RepositorioGenerico(GuayaswestSampleContexto GuayaswestSampleContexto)
        {
            _GuayaswestSampleContexto = GuayaswestSampleContexto;
        }

        public void Actualizar(TEntidad entidad)
        {
            _GuayaswestSampleContexto.Set<TEntidad>().Update(entidad);
            _GuayaswestSampleContexto.SaveChanges();
        }

        public IQueryable<TEntidad> BuscarPorCondicion(Expression<Func<TEntidad, bool>> expresion)
        {
            return _GuayaswestSampleContexto.Set<TEntidad>().Where(expresion).AsNoTracking();
        }

        public void Eliminar(TEntidad entidad)
        {
            _GuayaswestSampleContexto.Set<TEntidad>().Remove(entidad);
        }

        public void Insertar(TEntidad entidad)
        {
            _GuayaswestSampleContexto.Set<TEntidad>().Add(entidad);
            _GuayaswestSampleContexto.SaveChanges();
        }

        public IQueryable<TEntidad> ObtenerTodo()
        {
            return _GuayaswestSampleContexto.Set<TEntidad>().AsNoTracking();
        }
    }
}