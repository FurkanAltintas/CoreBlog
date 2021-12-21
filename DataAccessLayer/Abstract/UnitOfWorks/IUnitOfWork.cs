using DataAccessLayer.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IAboutDal About { get; }
        IBlogDal Blog { get; }
        ICategoryDal Category { get; }
        ICommentDal Comment { get; }
        IContactDal Contact { get; }
        IMessageDal Message { get; }
        INewsletterDal Newsletter { get; }
        INotificationDal Notification { get; }
        IWriterDal Writer { get; }
        int Save();
    }
}
