using Insurance.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Infrastructure.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public InsuranceContext _insuranceContext;
        public GenericRepository(InsuranceContext insuranceContext)
        {
            _insuranceContext = insuranceContext;
        }
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            return _insuranceContext.GetCollection<T>();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
