using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIS.Models;

namespace VIS.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
            VISContext dbContext = new VISContext();
			ViewBag.Message = "Dashboard";

            ViewBag.vehicles = (from v in dbContext.Vehicles select v).Count();

			return View();
		}
	}
}
