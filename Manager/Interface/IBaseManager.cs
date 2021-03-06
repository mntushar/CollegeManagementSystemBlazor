using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IBaseManager<T> where T : class
    {
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Remove(T entity);
        public T Get(int? id);
        public ICollection<T> GetAll();
        public Task<List<T>> GetAllList();
    }
}
