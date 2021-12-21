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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void Delete(Writer t)
        {
            _writerDal.Delete(t);
        }

        public Writer Get(int id)
        {
            return _writerDal.Get(id);
        }

        public Writer Get(Expression<Func<Writer, bool>> filter = null)
        {
            return filter == null ?
                _writerDal.Get() :
                _writerDal.Get(filter);
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter = null)
        {
            return filter == null ?
                _writerDal.GetListAll() :
                _writerDal.GetListAll(filter);
        }

        public Writer Login(Writer writer)
        {
            return _writerDal.Get(x => x.Mail == writer.Mail && x.Password == writer.Password);
        }

        public List<Writer> Ordered(Expression<Func<Writer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            _writerDal.Update(t);
        }
    }
}
