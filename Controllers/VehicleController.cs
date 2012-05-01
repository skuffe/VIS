using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIS.Models;

namespace VIS.Controllers
{ 
    public class VehicleController : Controller
    {
        private VISContext db = new VISContext();

        //
        // GET: /Vehicle/

        public ViewResult Index()
        {
            return View(db.Vehicles.ToList());
        }

        //
        // GET: /Vehicle/Details/5

        public ViewResult Details(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Vehicle/Create

        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(vehicle);
        }
        
        //
        // GET: /Vehicle/Edit/5
 
        public ActionResult Edit(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Edit/5

        [HttpPost]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Delete/5
 
        public ActionResult Delete(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}