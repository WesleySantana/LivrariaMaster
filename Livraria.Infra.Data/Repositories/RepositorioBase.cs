using Livraria.Domain.Interfaces;
using Livraria.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Infra.Data.Repositories
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        private LivrariaContext _Db;

        public RepositorioBase(LivrariaContext context)
        {
            _Db = context;
        }

        public virtual List<TEntity> GetAll()
        {
            return _Db.Set<TEntity>().AsNoTracking().ToList();
        }       

        public virtual TEntity GetById(int id)
        {
            return _Db.Set<TEntity>().Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            _Db.Update(entity);
        }

        public virtual void Save(TEntity entity)
        {
            _Db.Set<TEntity>().Add(entity);
        }

        public virtual void Commit(TEntity entity)
        {
            _Db.Set<TEntity>().Add(entity);
            _Db.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            _Db.Remove(entity);
        }
    }
}
