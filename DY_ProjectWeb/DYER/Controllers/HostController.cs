using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DYER.Controllers
{
    public class HostController : Controller
    {
        // GET: Host
        public ActionResult Index()
        {
            DYEREntity.EF.EntityConnection db = new DYEREntity.EF.EntityConnection();
            var host = from h in db.tbl_Host
                       select h;
            return View(host);
        }

        // GET: Host/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Host/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Host/Create
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

        // GET: Host/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Host/Edit/5
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

        // GET: Host/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Host/Delete/5
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
