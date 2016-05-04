using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleInjectorSetup.Core.Services;

namespace SimpleInjectorSetup.Controllers
{
	public class HomeController : Controller
	{
		private readonly ISimpleService _simpleService;
		public HomeController(ISimpleService simpleService)
		{
			_simpleService = simpleService;
		}

		public ActionResult Index()
		{
			var simple = _simpleService.GetSimpleMessage();
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}