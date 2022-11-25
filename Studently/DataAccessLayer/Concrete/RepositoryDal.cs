using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class RepositoryDal<T> : IRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using (Context c = new Context())
            {
                var addedEntity = c.Entry(entity);
                addedEntity.State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context c = new Context())
            {
                var deletedEntity = c.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (Context c = new Context())
            {
                return filter == null ? c.Set<T>().ToList() : c.Set<T>().Where(filter).ToList();
            }
        }

        public T GetId(int id)
        {
            using (Context c = new Context())
            {
                return c.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (Context c = new Context())
            {
                var updatedEntity = c.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
