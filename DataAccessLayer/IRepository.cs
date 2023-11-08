using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        Task<int> Insert(T nesne);
        Task<int> Update(T nesne);
        Task<int> Delete(T nesne);
        Task<List<T>> Liste();
        Task<List<T>> Liste(Expression<Func<T, bool>> kosul);
        Task<T> Find(Expression<Func<T, bool>> kosul);
      
    }
}
