using DataAccessLayer.Abstract.Repositories;
using DataAccessLayer.Abstract.UnitOfWorks;
using DataAccessLayer.Concrete.EntityFramework.Contexts;
using DataAccessLayer.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public IAboutDal About { get; private set; }

        public IBlogDal Blog { get; private set; }

        public ICategoryDal Category { get; private set; }

        public ICommentDal Comment { get; private set; }

        public IContactDal Contact { get; private set; }

        public IMessageDal Message { get; private set; }

        public INewsletterDal Newsletter { get; private set; }

        public INotificationDal Notification { get; private set; }

        public IWriterDal Writer { get; private set; }

        public UnitOfWork(Context context)
        {
            _context = context;
            About = new EfAboutRepository();
            Blog = new EfBlogRepository();
            Category = new EfCategoryRepository();
            Comment = new EfCommentRepository();
            Contact = new EfContactRepository();
            Message = new EfMessageRepository();
            Newsletter = new EfNewsletterRepository();
            Notification = new EfNotificationRepository();
            Writer = new EfWriterRepository();
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
