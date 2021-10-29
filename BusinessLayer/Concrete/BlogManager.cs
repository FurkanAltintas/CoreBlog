using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Blog> FetchWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id).TakeLast(2).ToList();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public Blog LastPost()
        {
            return _blogDal.GetById();
        }

        public List<Blog> List()
        {
            return _blogDal.GetListAll();
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
