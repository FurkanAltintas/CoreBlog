using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> List(Expression<Func<T, bool>> filter = null);
        List<T> Ordered(Expression<Func<T, bool>> filter = null);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T Get(int id);
        T Get(Expression<Func<T, bool>> filter = null);
    }
}
