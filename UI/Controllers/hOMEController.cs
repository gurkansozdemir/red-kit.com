using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.PopupMessage = TempData["Warning"];
            RedKitContext cnt = new RedKitContext();
            //List<SignUp> test = cnt.SignUp.ToList();
            return View();
        }
    }
}