using EjercicioPractico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPractico.Controllers
{
    public class AlquilerController : Controller
    {
        private EjercicioPracticoContext db;

        public AlquilerController()
        {
            db = new EjercicioPracticoContext();
        }

        public ActionResult Alquiler()
        {
            var users = db.Users.ToList();
            var coches = db.Coches.ToList();

            var viewModel = new NewAlquilerViewModel
            {
                Users = users,
                Coches = coches
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateAlquiler(Alquiler Alquiler)
        {
            db.Alquilers.Add(Alquiler);
            db.SaveChanges();

            return RedirectToAction("Alquiler");
        }

        public ActionResult ListAlquiler()
        {
            var alquiler = db.Alquilers.ToList();
            List<User> user = new List<User>();
            List<Coche> coche = new List<Coche>();

            foreach(var num in alquiler)
            {
                user.Add(db.Users.Find(num.IdUser));
                coche.Add(db.Coches.Find(num.IdCoche));
            }

            var list = new NewAlquilerViewModel
            {
                Users = user,
                Coches = coche
            };

            return View(list);
        }
    }
}