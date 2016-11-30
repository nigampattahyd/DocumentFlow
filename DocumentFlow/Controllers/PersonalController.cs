using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DF.Business.Interfaces;
using DF.Business.Model.EntityFramework;
using DF.Business.Repository;

namespace DocumentFlow.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IUser _userRepository = null;
        private readonly IErrologs _errorRepository = null;
        private readonly IUsertype _usertypeRepository = null;
        //constructor
        public PersonalController()
        {
            this._userRepository = new UserRepo();
            this._errorRepository = new ErroLogsRepo();
            this._usertypeRepository = new UserTypeRepo();
        }
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
            User loggedinUser = _userRepository.getUserDetailsById(1);
            return View(loggedinUser);
        }
        [HttpPost]
        public ActionResult UpdateUser(User user, HttpPostedFileBase upload)
        {
            try
            {
                if (upload != null && upload.ContentLength > 0)
                {

                    using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    {
                        user.ProfilePic = reader.ReadBytes(upload.ContentLength);
                    }

                }
                _userRepository.updateUser(user);
            }
            catch (Exception ex)
            {
                ErrorLog errLog = new ErrorLog();
                errLog.ErrorMessage = ex.Message;
                errLog.Procedure_Name = "Personal Controller";
                errLog.Method = "Users";
                errLog.CreatedOn = System.DateTime.Now;
                _errorRepository.inserterorlogs(errLog);
                return null;
            }
            return RedirectToAction("SAmpleDesign");
        }
    }
}