using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupWork.DAL;
using GroupWork.Models;

namespace GroupWork.Controllers
{
    public class HomeController : Controller
    {
        private RecordContext db = new RecordContext();
        public ActionResult Index(int id)
        {
            Session["UserID"] = id; //Save session value
            User user = db.Users.Find(id);
            if (user == null)
            {
                id = 1;
            }
            var selectedUser = db.Users.Where(p => p.ID == (int)id);
            return View(selectedUser);
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
    }
}