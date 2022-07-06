using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManeger : IMessageService
    {

        IMessageDal _messageDal;

        public MessageManeger(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListDraftbox()
        {
            return _messageDal.List(x => x.SenderMail == " " || x.Subject == "" || x.ReceiverMail == "");
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendeBox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public List<Message> GetListTrashBox()
        {
            return _messageDal.List(x => x.MessageStatus == false );
        }

        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            _messageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
