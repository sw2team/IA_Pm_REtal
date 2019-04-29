using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pm_retal.Models;
using System.IO;
using System.Web.Security;
using System.Data.Entity;
using pm_retal.ViewModels;

namespace pm_retal.Controllers
{
    public class ProjectsController : Controller
    {
        OurDbContext db = new OurDbContext();
       
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addproject(Projects projects, UserAccount userAccount)
        {

            using (OurDbContext db = new OurDbContext())
            {
               projects.Customer_ID = Convert.ToInt32(Session["UserID"]);
                projects.status = "pen";
                db.projects.Add(projects);
                db.SaveChanges();
            }


            ViewBag.Message = projects.post_Name + "succesfully Added";
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        public ActionResult AddPmToProject(Projects project)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var id = project.ID;
                Projects projects = db.projects.Find(project.ID);
             
                projects.PM_ID = project.PM_ID;
                db.Entry(projects).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Profile", "Home");
            }
        }
        [HttpGet]
        public ActionResult Approveproject(int id)
        {

            using (OurDbContext db = new OurDbContext())
            {
                Projects projects = db.projects.Find(id);
                
                projects.status = "apro";
                db.Entry(projects).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("profile","Home");
        }
        [HttpGet]
        public ActionResult DeletePost(int id)
        {

            // var user = db.userAccount.Single(c => c.UserType_Id == id);
            Projects projects = db.projects.Find(id);
            db.projects.Remove(projects);
            db.SaveChanges();

            return RedirectToAction("profile","Home");

        }
        [HttpGet]
        public ActionResult RequsetProject(int id)
        {

            using (OurDbContext db = new OurDbContext())
            {
                Projects projects = db.projects.Find(id);
                ASTPM aSTPM = new ASTPM();
                aSTPM.PM_ID = Convert.ToInt32(Session["UserID"]);
                aSTPM.Project_ID = projects.ID;
                aSTPM.Customer_ID = projects.Customer_ID;
                db.Astpm.Add(aSTPM);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}