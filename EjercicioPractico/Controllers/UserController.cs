using EjercicioPractico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPractico.Controllers
{
    public class UserController : Controller
    {
        private EjercicioPracticoContext db;

        public UserController()
        {
            db = new EjercicioPracticoContext();
        }
        public ActionResult User()
        {
            var user = db.Users.ToList();
            return View(user);
        }

        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return RedirectToAction("User");
        }
    }
}