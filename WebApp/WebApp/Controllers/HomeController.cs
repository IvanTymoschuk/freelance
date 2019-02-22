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
        Context ctx = new Context();
        public ActionResult Index()
        {
           
            return View();
        }

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

        public ActionResult JobsList()
        {

            var model = new JobsListModel()
            {
                jobs = ctx.Jobs.Include("Category").Include("City").ToList(),
                Categories = ctx.Categories.ToList(),
                Cities = ctx.Cities.ToList()
            };

            return View(model);
        }
    }
}