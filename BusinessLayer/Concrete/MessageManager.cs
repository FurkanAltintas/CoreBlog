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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message t)
        {
            _messageDal.Insert(t);
        }

        public void Delete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message Get(int id)
        {
            return _messageDal.Get(id);
        }

        public Message Get(Expression<Func<Message, bool>> filter = null)
        {
            return filter == null ?
                _messageDal.Get() :
                _messageDal.Get(filter);
        }

        public List<Message> List(Expression<Func<Message, bool>> filter = null)
        {
            return filter == null ?
                _messageDal.GetListAll() :
                _messageDal.GetListAll(filter);
        }

        public List<Message> List(string mail, int number)
        {
            var message = _messageDal.GetListAll(x => x.Receiver == mail).TakeLast(number).Reverse().ToList();
            return message == null ? _messageDal.GetListAll(x => x.Receiver == mail).OrderByDescending(x => x.MessageId).ToList() : message;
        }

        public void Update(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
