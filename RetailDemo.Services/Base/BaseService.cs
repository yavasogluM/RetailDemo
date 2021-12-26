using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RetailDemo.Services.Base
{
    //TODO: we can implement DB or specific common methods with this class
    public class BaseService<T> : IBaseService<T>  where T : class
    {
        public BaseService()
        {
        }

        public Task<List<T>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetListBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
