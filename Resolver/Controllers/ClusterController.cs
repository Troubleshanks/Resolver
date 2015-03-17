using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resolver.Controllers
{
    public class ClusterController : Controller
    {
        // GET: Cluster
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cluster/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cluster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cluster/Create
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

        // GET: Cluster/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cluster/Edit/5
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

        // GET: Cluster/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cluster/Delete/5
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
