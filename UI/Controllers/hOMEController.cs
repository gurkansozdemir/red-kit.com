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
            if (TempData["Success"]!=null)
            {
                ViewBag.PopupMessage = TempData["Success"];
            }
            else if(TempData["Warning"] != null)
            {
                ViewBag.PopupMessage = TempData["Warning"];
            }
            RedKitContext cnt = new RedKitContext();
            //List<SignUp> test = cnt.SignUp.ToList();
            return View();
        }
    }
}