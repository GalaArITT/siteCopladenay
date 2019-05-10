using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace siteCOPLADENAY.Controllers
{
    public class SesionesController : Controller
    {
        // GET: Sesiones
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sesiones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sesiones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sesiones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sesiones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sesiones/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sesiones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sesiones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
