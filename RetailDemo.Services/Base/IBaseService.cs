using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RetailDemo.Services.Base
{
    public interface IBaseService<T>
    {
        Task<List<T>> GetList();
        Task<List<T>> GetListBy(Expression<Func<T, bool>> predicate);
        
    }
}
