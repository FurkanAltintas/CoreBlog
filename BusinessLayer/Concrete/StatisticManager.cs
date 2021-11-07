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
    public class StatisticManager : IStatisticService
    {
        IBlogDal _blogDal;
        ICategoryDal _categoryDal;

        public StatisticManager(IBlogDal blogDal, ICategoryDal categoryDal)
        {
            _blogDal = blogDal;
            _categoryDal = categoryDal;
        }

        public List<Blog> Blog()
        {
            return _blogDal.GetListAll();
        }

        public int BlogByWriterCount(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id).Count();
        }

        public int BlogCount()
        {
            return _blogDal.GetListAll().Count();
        }

        public int Category()
        {
            return _categoryDal.GetListAll().Count();
        }
    }
}
