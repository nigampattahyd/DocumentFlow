using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using DocumentFlow.Models;

namespace DocumentFlow.Controllers
{
    public class AdministrativeController : Controller
    {
        // GET: Administrative
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Users()
        {
            //write the logic to display he data of users
            string cs = @"Data Source=CHINTALAS\SQLEXPRESS;Initial Catalog=DF_Default;Integrated Security=True";
            List<User> userlst = new List<User>();
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        User singleuser = new User();
                        singleuser.id = Convert.ToInt32(dr["id"]);
                        singleuser.UserName = dr["UserName"].ToString();
                        //singleuser.Password = dr["Passord"].ToString();
                        singleuser.FirstName = dr["FirstName"].ToString();
                        singleuser.LastName = dr["LastName"].ToString();
                        singleuser.Gender = dr["Gender"].ToString();
                        singleuser.DOB = Convert.ToDateTime(dr["DOB"]).Date;
                        singleuser.EmailAddress = dr["EmailAddress"].ToString();
                        singleuser.Address = dr["Address"].ToString();
                        singleuser.City = dr["City"].ToString();
                        singleuser.State = dr["State"].ToString();
                        singleuser.Country = dr["Country"].ToString();
                        //singleuser.Zip = Convert.ToInt32(dr["Zip"]);
                        singleuser.About = dr["About"].ToString();
                        singleuser.UserTypeId = Convert.ToInt32(dr["UserTypeId"]);
                        singleuser.CreatedOn = Convert.ToDateTime(dr["CreatedOn"]).Date;
                        singleuser.CreatedBy = Convert.ToInt32(dr["CreatedBy"]);
                        //singleuser.ModifiedOn = Convert.ToDateTime(dr["ModifiedOn"]).Date;
                        //singleuser.ModifiedBy = Convert.ToInt32(dr["ModofiedBy"]);
                        //singleuser.IsActive = Convert.ToInt32(dr["IsActive"]);
                        //singleuser.IsLocked = Convert.ToInt32(dr["IsLocked"]);
                        userlst.Add(singleuser);
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            var userdata = userlst;
            return View(userdata);
        }
        [HttpGet]
        public ActionResult Roles()
        {
            return View();
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
        public ActionResult Delete(int id)
        {
            string cs = @"Data Source=CHINTALAS\SQLEXPRESS;Initial Catalog=DF_Default;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("delete from [User] where id="+id, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Users");
        }
        public ActionResult CreateRole()
        {
            return View();
        }
     
        //public ActionResult CreateUserModel()
        //{
        //    return View();
        //}
    }
}