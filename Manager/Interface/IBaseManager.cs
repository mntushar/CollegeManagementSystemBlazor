using Models.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public List<T> GetAllList();
    }
}
