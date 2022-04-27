using Services.Interface;
using Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.BaseManager
{
    public class BaseManager<T> : IBaseManager<T> where T : class
    {
        private IBaseRepositorie<T> _baseRepositorie;

        public BaseManager(IBaseRepositorie<T> baseRepositorie)
        {
            _baseRepositorie = baseRepositorie;
        }

        public virtual bool Add(T entity)
        {
            return _baseRepositorie.Add(entity);
        }

        public virtual T Get(int? id)
        {
            return _baseRepositorie.Get(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _baseRepositorie.GetAll();
        }

        public virtual bool Remove(T entity)
        {
            return _baseRepositorie.Remove(entity);
        }

        public virtual bool Update(T entity)
        {
            return _baseRepositorie.Update(entity);
        }

        public virtual async Task<List<T>> GetAllList()
        {
            return await _baseRepositorie.GetAllList();
        }
    }
}
