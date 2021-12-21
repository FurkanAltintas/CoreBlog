using BusinessLayer.Abstract;
using DataAccessLayer.Abstract.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void Delete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(id);
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                _categoryDal.Get() :
                _categoryDal.Get(filter);
        }

        public List<Category> List(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                _categoryDal.GetListAll() :
                _categoryDal.GetListAll(filter);
        }

        public List<Category> Ordered(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
