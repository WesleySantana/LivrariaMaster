using System.Collections.Generic;

namespace Livraria.Application.Interfaces
{
    public interface IRepositorioBaseApp<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Update(TEntity entity);
        void Save(TEntity entity);
        void Commit(TEntity entity);
        void Delete(TEntity entity);
    }
}
