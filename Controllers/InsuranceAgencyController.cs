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
    public class InsuranceAgencyController : Controller
    {
        private VISContext db = new VISContext();

        //
        // GET: /InsuranceAgency/

		[Authorize]
        public ViewResult Index()
        {
			var insuranceAgencies = db.InsuranceAgencies.OrderByDescending(a => a.Name);
            return View(insuranceAgencies.ToList());
        }

        //
        // GET: /InsuranceAgency/Details/5

		[Authorize]
        public ViewResult Details(int id)
        {
            InsuranceAgency insuranceagency = db.InsuranceAgencies.Find(id);
            return View(insuranceagency);
        }

        //
        // GET: /InsuranceAgency/Create

		[Authorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /InsuranceAgency/Create

		[Authorize]
        [HttpPost]
        public ActionResult Create(InsuranceAgency insuranceagency)
        {
            if (ModelState.IsValid)
            {
                db.InsuranceAgencies.Add(insuranceagency);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(insuranceagency);
        }
        
        //
        // GET: /InsuranceAgency/Edit/5
 
		[Authorize]
        public ActionResult Edit(int id)
        {
            InsuranceAgency insuranceagency = db.InsuranceAgencies.Find(id);
            return View(insuranceagency);
        }

        //
        // POST: /InsuranceAgency/Edit/5

		[Authorize]
        [HttpPost]
        public ActionResult Edit(InsuranceAgency insuranceagency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuranceagency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuranceagency);
        }

        //
        // GET: /InsuranceAgency/Delete/5
 
		[Authorize]
        public ActionResult Delete(int id)
        {
            InsuranceAgency insuranceagency = db.InsuranceAgencies.Find(id);
            return View(insuranceagency);
        }

        //
        // POST: /InsuranceAgency/Delete/5

		[Authorize]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            InsuranceAgency insuranceagency = db.InsuranceAgencies.Find(id);
            db.InsuranceAgencies.Remove(insuranceagency);
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