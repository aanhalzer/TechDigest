using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechDigest.Web.Models;

namespace TechDigest.Web.Controllers
{
    public class HomeController : Controller
    {
        private tdigestdbEntities db = new tdigestdbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Week(int id)
        {
            IEnumerable<News> list = from n in db.News where n.WeekId == id select n;
            ViewBag.Week = id.ToString();
            return View(list);
        }
    }
}