using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Infrastructure.Contracts
{
    public interface IRepository<T>
    {
        T Add(T newEntity);

        void Remove(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);

        T GetById(Guid id);
    }
}
