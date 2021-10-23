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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public bool Login(Writer writer)
        {
            var login = _writerDal.GetListAll(x => x.FullName == writer.FullName && x.Password == writer.Password);

            if (login != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register(Writer writer)
        {
            _writerDal.Insert(writer);
        }
    }
}
