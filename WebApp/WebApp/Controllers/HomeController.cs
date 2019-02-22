using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult UserInfo(int id)
        {
            //try
            //{
                using (Context ctx = new Context())
                {
                    User user = ctx.Users.Include("City").FirstOrDefault(x => x.ID == id);
                    if (user == null)
                    {
                        return HttpNotFound($"User with id [ {id} ] NOT FOUND");
                    }
                    UserInfoModel model = new UserInfoModel();
                    model.user = user;
                    var job = ctx.Jobs.FirstOrDefault(x => x.UserOwner.ID == user.ID);
                    if (job != null)
                    {
                        foreach (var el in ctx.Jobs)
                            if (el.UserOwner == user)
                                model.jobs.Add(el);
                    
                    }
                    return View(model);
                }
            //}
            //catch (Exception)
            //{
            //    return new HttpStatusCodeResult(500, "ID IS NO VALID");
            //}
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Profile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult CreateAD()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JobsList()
        {
            using (Context ctx = new Context())
            {
                var model = new JobsListModel()
                {

                    jobs = ctx.Jobs.Include("Category").Include("City").ToList(),
                    Categories = ctx.Categories.ToList(),
                    Cities = ctx.Cities.ToList()
                };
                return View(model);
            };

          
        }
    }
}