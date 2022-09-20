using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        IList<T> GetAll();
        T GetById(long id);
        void Update(T entity);
        void Delete(T entity);
    }
}
