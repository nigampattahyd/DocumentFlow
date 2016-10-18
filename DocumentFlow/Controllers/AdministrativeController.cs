using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using DF.Business.Repository;
using DF.Business.Interfaces;
using DF.Business.Model.EntityFramework;

namespace DocumentFlow.Controllers
{
    public class AdministrativeController : Controller
    {
        private readonly IUser _userRepository = null;
        private readonly IErrologs _errorRepository = null;
        private readonly IUsertype _usertypeRepository = null;
        //constructor
        public AdministrativeController()
        {
            this._userRepository = new UserRepo();
            this._errorRepository = new ErroLogsRepo();
            this._usertypeRepository = new UserTypeRepo();
        }
        // GET: Administrative
        //users
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Users()
        {
            try
            {
                List<User> lstUsers = new List<User>();
                lstUsers = _userRepository.getAllUsers();
                return View(lstUsers);
            }
            catch (Exception ex)
            {
                ErrorLog errLog = new ErrorLog();
                errLog.ErrorMessage = ex.Message;
                errLog.Procedure_Name = "Administrative Controller";
                errLog.Method = "Users";
                errLog.CreatedOn = System.DateTime.Now;
                _errorRepository.inserterorlogs(errLog);
                return null;
            }

        }
        [HttpGet]
        public ActionResult DashboardSetUp()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Reports()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Tools()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            try
            {
                _userRepository.deleteUser(id);
            }
            catch (Exception ex)
            {
                ErrorLog errLog = new ErrorLog();
                errLog.ErrorMessage = ex.Message;
                errLog.Procedure_Name = "Administrative Controller";
                errLog.Method = "Users";
                errLog.CreatedOn = System.DateTime.Now;
                _errorRepository.inserterorlogs(errLog);
                return null;
            }
            return RedirectToAction("Users");
        }
        [HttpPost]
        public ActionResult InsertUser(User user)
        {
            try
            {
                _userRepository.createUser(user);
            }
            catch (Exception ex)
            {
                ErrorLog errLog = new ErrorLog();
                errLog.ErrorMessage = ex.Message;
                errLog.Procedure_Name = "Administrative Controller";
                errLog.Method = "Users";
                errLog.CreatedOn = System.DateTime.Now;
                _errorRepository.inserterorlogs(errLog);
                return null;
            }
            return RedirectToAction("Users");
        }
        //uertype
        public ActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertUserType(UserType usertype)
        {
            try
            {
                _usertypeRepository.CreateUserType(usertype);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("UserType");
        }
        [HttpGet]
        public ActionResult DeleteUserType(int id)
        {
            try
            {
                _usertypeRepository.DeleteUserType(id);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("UserType");
        }
        [HttpGet]
        public ActionResult EditUserType(int id)
        {
            UserType usertyperetreived = new UserType();
            try
            {
                usertyperetreived = _usertypeRepository.GetUserTypeById(id);
            }
            catch (Exception)
            {

                throw;
            }
            return View(usertyperetreived);
        }
        [HttpPost]
        public ActionResult SaveEditedUserType(UserType usertype)
        {
            try
            {
                _usertypeRepository.UpdateUserType(usertype);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("UserType");
        }
        [HttpGet]
        public ActionResult UserType()
        {
            List<UserType> usertypelist = _usertypeRepository.GetAllUserTypes();
            return View(usertypelist);
        }
    }
}