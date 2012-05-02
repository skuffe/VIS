using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIS.Models;

namespace VIS.Controllers
{
    public class DashboardController : Controller
    {
		private VISContext dbContext = new VISContext();
        //
        // GET: /Dashboard/

		[Authorize]
        public ActionResult Index()
        {
            ViewBag.VehiclesCount = (from v in dbContext.Vehicles select v).Count();
			ViewBag.InsuranceAgenciesCount = (from a in dbContext.InsuranceAgencies select a).Count();
			
            return View();
        }

    }
}
