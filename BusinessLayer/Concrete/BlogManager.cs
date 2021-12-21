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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public List<Blog> FetchCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> FetchCategoryByWriter(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public List<Blog> FetchWriter(int id, int number)
        {
            return _blogDal.GetListAll(x => x.WriterId == id).TakeLast(number).ToList();
        }

        public Blog Get(int id)
        {
            return _blogDal.Get(id);
        }

        public Blog Get(Expression<Func<Blog, bool>> filter = null)
        {
            return filter == null ?
                _blogDal.Get() :
                _blogDal.Get(filter);
        }

        public Blog LastPost()
        {
            return _blogDal.Get();
        }

        public List<Blog> List(Expression<Func<Blog, bool>> filter = null)
        {
            return filter == null ?
                _blogDal.GetListAll() :
                _blogDal.GetListAll(filter);
        }

        public List<Blog> Ordered(Expression<Func<Blog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Blog> RecentPost(int number)
        {
            return _blogDal.GetListAll().TakeLast(number).ToList();
        }

        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
