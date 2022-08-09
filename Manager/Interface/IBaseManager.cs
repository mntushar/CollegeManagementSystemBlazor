using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IBaseManager<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        T Get(int? id);
        ICollection<T> GetAll();
        Task<List<T>> GetAllList();
    }
}
