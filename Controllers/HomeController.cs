﻿using System;
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
			if (Request.IsAuthenticated) {
				return RedirectToAction("Index", "Dashboard");
			} else {
				return View();
			}
		}
	}
}
