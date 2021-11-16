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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification t)
        {
            _notificationDal.Insert(t);
        }

        public void Delete(Notification t)
        {
            _notificationDal.Delete(t);
        }

        public Notification Get(int id)
        {
            return _notificationDal.Get(id);
        }

        public Notification Get(Expression<Func<Notification, bool>> filter = null)
        {
            return filter == null ?
                _notificationDal.Get() :
                _notificationDal.Get(filter);
        }

        public List<Notification> List(Expression<Func<Notification, bool>> filter = null)
        {
            return filter == null ?
                _notificationDal.GetListAll() :
                _notificationDal.GetListAll(filter);
        }

        public List<Notification> List(bool passive, int number)
        {
            return _notificationDal.GetListAll(x => x.IsActive == passive).TakeLast(number).Reverse().ToList();
        }

        public void Update(Notification t)
        {
            _notificationDal.Update(t);
        }
    }
}
