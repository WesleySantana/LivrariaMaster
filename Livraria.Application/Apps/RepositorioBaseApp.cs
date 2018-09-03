using Livraria.Application.Interfaces;
using Livraria.Domain.Interfaces;
using System.Collections.Generic;

namespace Livraria.Application.Apps
{
    public class RepositorioBaseApp<TEntity> : IRepositorioBaseApp<TEntity> where TEntity : class
    {
        private IRepositorioBase<TEntity> _repositorio;

        public RepositorioBaseApp(IRepositorioBase<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual void Save(TEntity entity)
        {
            _repositorio.Save(entity);
        }

        public void Commit(TEntity entity)
        {
            _repositorio.Commit(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repositorio.Update(entity);
        }

        public virtual List<TEntity> GetAll()
        {
            return _repositorio.GetAll();
        }       

        public virtual TEntity GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Delete(TEntity entity)
        {
            _repositorio.Delete(entity);
        }
    }
}
