using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoEventoFFContext Db = new ProjetoEventoFFContext();


        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var r = Db.Set<TEntity>().ToList();
            return r;
        }

        public TEntity GetById(int id)
        {
            var r =  Db.Set<TEntity>().Find(id);
            return r;
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
