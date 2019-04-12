using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pm_retal.Models;
using System.IO;
namespace pm_retal.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (OurDbContext db = new OurDbContext())
            {
                return View(db.userAccount.ToList());
            }
            
        }
        public ActionResult Register() {

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
       
        public ActionResult LoggedIn() {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else {
                return RedirectToAction("Login");
            }
        }
    }
}