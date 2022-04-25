using Microsoft.EntityFrameworkCore;
using Models.DbContexts;
using Models.Helper;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.BaseRepositorie
{
    public class BaseRepositorie<T> : IBaseRepositorie<T> where T : class
    {
        protected CollegeDbContext _db;
        private DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }

        public BaseRepositorie()
        {
            _db = new CollegeDbContext();
        }

        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual T Get(int? id)
        {
            return Table.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual List<T> GetAllList()
        {
            return Table.ToList();
        }
    }
}
