using System.Collections.Generic;

namespace Livraria.Domain.Interfaces
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Save(TEntity entity);
        void Commit(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
