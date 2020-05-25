using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {
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

        public string HelloWorld(string firstName, string lastName)
        {
            return $"Hello World from {firstName} {lastName}!";
        }

        public string getUser(int id)
        {
            return $"Hello form the User_{id}";
        }

        public ActionResult GetListUser(string name)
        {
            IList<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            ViewBag.Message = $"User list from {name}";
            ViewBag.MyList = myList;
            return View();

            //two methods to return other view.
            //return View("about");
            //return RedirectToAction("Contact");
        }
    }
}