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

		[Authorize]
        public ViewResult Index(string searchString)
        {
            var vehicles = db.Vehicles.Include(v => v.InsuranceAgency);
            if (!String.IsNullOrEmpty(searchString))
            {
                vehicles = vehicles.Where(s => s.Model.ToUpper().Contains(searchString.ToUpper()));
            }
            return View(vehicles.ToList());
        }

        //
        // GET: /Vehicle/Details/5

		[Authorize]
        public ViewResult Details(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Create

		[Authorize]
        public ActionResult Create()
        {
            ViewBag.InsuranceAgencyID = new SelectList(db.InsuranceAgencies, "InsuranceAgencyID", "Name");
            return View();
        } 

        //
        // POST: /Vehicle/Create

		[Authorize]
        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.InsuranceAgencyID = new SelectList(db.InsuranceAgencies, "InsuranceAgencyID", "Name", vehicle.InsuranceAgencyID);
            return View(vehicle);
        }
        
        //
        // GET: /Vehicle/Edit/5
 
		[Authorize]
        public ActionResult Edit(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            ViewBag.InsuranceAgencyID = new SelectList(db.InsuranceAgencies, "InsuranceAgencyID", "Name", vehicle.InsuranceAgencyID);
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Edit/5

		[Authorize]
        [HttpPost]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InsuranceAgencyID = new SelectList(db.InsuranceAgencies, "InsuranceAgencyID", "Name", vehicle.InsuranceAgencyID);
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Delete/5
 
		[Authorize]
        public ActionResult Delete(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Delete/5

		[Authorize]
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