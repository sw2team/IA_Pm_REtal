using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pm_retal.Models;
using System.IO;
using System.Web.Security;
using System.Data.Entity;

namespace pm_retal.Controllers
{
    public class HomeController : Controller
    {
       /* private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        } */
        public ActionResult Profile()
        {
            using (OurDbContext db = new OurDbContext())
            {
                return View(db.userAccount.ToList());
            }
        }
        public ActionResult Index()
        {

            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {

                //string fileName = null;
                //string extension = null;
                string fileName = Path.GetFileNameWithoutExtension(account.ImageFile.FileName);
                string extension = Path.GetExtension(account.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                account.ImagePath =fileName;
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                account.ImageFile.SaveAs(fileName);

                using (OurDbContext db = new OurDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FullName + "succesfully registerd";
                return RedirectToAction("Login");
            }
            else {
                ViewBag.Message = "username or passsword is wrong.";
                
                 
                string newUrl = Url.Action("Login#signup");
                string plussedUrl = newUrl.Replace("%23", "#");
                return new RedirectResult(plussedUrl);
                 
                //return RedirectToAction("Login#signup");
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {

            using (OurDbContext db = new OurDbContext())
            {
                if (user.Email != null && user.Password != null)
                {
                    //db.userAccount.Single(u => u.Email == user.Email && u.Password == user.Password);
                    var usr = db.userAccount.Where(u => u.Email.Equals(user.Email) && u.Password.Equals(user.Password)).FirstOrDefault();

                    if (usr != null)
                    {
                        Session["UserID"] = usr.UserID.ToString();
                        Session["Email"] = usr.Email.ToString();
                        Session["FullName"] = usr.FullName.ToString();
                        Session["ImgPath"] = usr.ImagePath.ToString();
                        Session["UserType_Id"] = usr.UserType_Id.ToString();
                        Session["JobDescription"] = usr.JobDescription.ToString();
                        Session["PhoneNumber"] = usr.PhoneNumber.ToString();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "username or passsword is wrong.");
                        return View();
                    }
                }
                else {
                    ModelState.AddModelError("", "PLZ fill All the fileds.");
                    return View();
                }
                
            }

        }

        /*public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }*/

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}