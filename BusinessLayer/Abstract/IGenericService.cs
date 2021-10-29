using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> List();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T GetById(int id);
    }
}
