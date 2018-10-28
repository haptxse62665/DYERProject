using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DYER.Controllers
{
    public class DYCController : Controller
    {
        // GET: DYC
        DYEREntity.EF.EntityConnection db = new DYEREntity.EF.EntityConnection();
        public ActionResult Index()
        {
            var dyc = from d in db.tbl_DYC
                      select d;
            return View(dyc);
        }

        // GET: DYC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DYC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DYC/Create
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

        // GET: DYC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DYC/Edit/5
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

        // GET: DYC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DYC/Delete/5
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
