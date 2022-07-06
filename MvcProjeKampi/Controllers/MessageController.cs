using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {

        MessageManeger cm = new MessageManeger(new EfMessageDal());

        public ActionResult Inbox()
        {
            var messageList=cm.GetListInbox();   
            return View(messageList);
        }
        public ActionResult Sendbox()
        {
            var messagelist = cm.GetListSendeBox();
            return View(messagelist);
        }
        public ActionResult Draftbox()
        {
            var messageList = cm.GetListDraftbox();
            return View(messageList);
        }
        public ActionResult TrashBox()
        {
            var messageList = cm.GetListTrashBox();
            return View(messageList);  
            //return RedirectToAction("Index");
        }
      
        [HttpGet]
        public ActionResult NewMessage()
        {

            return View();  
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            return View();  
        }
    }
}