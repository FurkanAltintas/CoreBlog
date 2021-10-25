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

        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> FetchCategory()
        {
            return _blogDal.GetListWithCategory(); //Kategorileri getirme
        }

        public List<Blog> FetchWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id).TakeLast(2).ToList(); // Son 2 blog listeleme
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
