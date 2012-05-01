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

        public ViewResult Index()
        {
            return View(db.InsuranceAgency.ToList());
        }

        //
        // GET: /InsuranceAgency/Details/5

        public ViewResult Details(int id)
        {
            InsuranceAgency insuranceagency = db.InsuranceAgency.Find(id);
            return View(insuranceagency);
        }

        //
        // GET: /InsuranceAgency/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /InsuranceAgency/Create

        [HttpPost]
        public ActionResult Create(InsuranceAgency insuranceagency)
        {
            if (ModelState.IsValid)
            {
                db.InsuranceAgency.Add(insuranceagency);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(insuranceagency);
        }
        
        //
        // GET: /InsuranceAgency/Edit/5
 
        public ActionResult Edit(int id)
        {
            InsuranceAgency insuranceagency = db.InsuranceAgency.Find(id);
            return View(insuranceagency);
        }

        //
        // POST: /InsuranceAgency/Edit/5

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
 
        public ActionResult Delete(int id)
        {
            InsuranceAgency insuranceagency = db.InsuranceAgency.Find(id);
            return View(insuranceagency);
        }

        //
        // POST: /InsuranceAgency/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            InsuranceAgency insuranceagency = db.InsuranceAgency.Find(id);
            db.InsuranceAgency.Remove(insuranceagency);
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