using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace siteCOPLADENAY.Controllers
{
    public class TransparenciaController : Controller
    {
        // GET: Transparencia
        public ActionResult Index()
        {
            return View();
        }

        // GET: Transparencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transparencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transparencia/Create
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

        // GET: Transparencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transparencia/Edit/5
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

        // GET: Transparencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transparencia/Delete/5
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
