using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EjercicioPractico.Controllers;
using EjercicioPractico.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EjercicioPractico.Test
{
    [TestClass]
    public class CocheControllerTest
    {
        [TestMethod]
        public void Coche()
        {
            CocheController coche = new CocheController();

            ViewResult result = coche.Coche() as ViewResult;

            var coc = (Coche) result.ViewData.Model;

            Assert.AreEqual("BMW", coc.Marca);
        }
    }
}
