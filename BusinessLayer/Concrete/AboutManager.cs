using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            _aboutDal.Insert(t);
        }

        public void Delete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About Get(int id)
        {
            return _aboutDal.Get();
        }

        public About Get(Expression<Func<About, bool>> filter = null)
        {
            return filter == null ?
                _aboutDal.Get() :
                _aboutDal.Get(filter);
        }

        public List<About> List(Expression<Func<About, bool>> filter = null)
        {
            return filter == null ?
                _aboutDal.GetListAll() :
                _aboutDal.GetListAll(filter);
        }

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
