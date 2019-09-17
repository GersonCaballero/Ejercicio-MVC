using EjercicioPractico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPractico.Controllers
{
    public class CocheController : Controller
    {
        // GET: Coche
        private EjercicioPracticoContext db;

        public CocheController()
        {
            db = new EjercicioPracticoContext();
        }

        public ActionResult Coche()
        {
            var coches = db.Coches.ToList();
            return View(coches);
        }

        public ActionResult CocheId(int id)
        {
            var coche = db.Coches.SingleOrDefault(C => C.Id == id);

            if (coche == null)
            {
                return HttpNotFound();
            }

            return View(coche);
        }

        public ActionResult NewCoche()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewCoche(Coche coche)
        {
            db.Coches.Add(coche);
            db.SaveChanges();

            return RedirectToAction("Coche");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}