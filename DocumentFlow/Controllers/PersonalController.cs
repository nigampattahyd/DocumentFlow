using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentFlow.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Mails()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MyDocuments()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AllDocuments()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SharedDocuments()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SharedToMe()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Favourites()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RecentDocumets()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DeletedDocuments()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UserHomePage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SAmpleDesign()
        {
            return View();
        }
    }
}