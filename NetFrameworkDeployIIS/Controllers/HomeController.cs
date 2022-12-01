using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace NetFrameworkDeployIIS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Console.WriteLine();
            return View();
        }

        public ActionResult About()
        {
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ViewBag.Message = $"Your application description page. Version: {assemblyVersion}";
            ViewBag.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}