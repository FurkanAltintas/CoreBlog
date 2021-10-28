using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); //Ekleme
        void Delete(T t); //Silme
        void Update(T t); //Güncelleme

        //List<T> GetListAll();

        List<T> GetListAll(Expression<Func<T, bool>> filter = null);

        //T GetById(int id);

        T GetByBind(Expression<Func<T, bool>> filter = null);
        T GetById(int? id = null);

        //Tek değer getirme ve listeleme filtrelenmiştir.
        //Insert ve Update tek değer olarak yapılabilir
        // id > 0 ise Update // id == 0 ise Insert
    }
}
