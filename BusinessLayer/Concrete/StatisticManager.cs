using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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

        public StatisticManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public int BlogByWriterCount(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id).Count();
        }

        public int BlogCount()
        {
            return _blogDal.GetListAll().Count();
        }

        public int BlogWeekCount()
        {
            return _blogDal.GetListAll().Count();
        }
    }
}
