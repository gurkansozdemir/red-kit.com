using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class SingUpController : Controller
    {
        //AtelierPortalContext db = new AtelierPortalContext();

        public ActionResult Index()
        {
            return View();
        }
        //{
        //    (doldur) currentUser = db.(doldur).Where(x => x.EMail == Email && x.Password == Password).SingleOrDefault();
        //    if (currentUser != null)
        //    {
        //        Session["CurrentUser"] = currentUser;
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Kullanıcı adı veya şifre hatalı.. Lutfen tekrar deneyiniz.";
        //        return View();
        //    }
        
        //public ActionResult Logout()
        //{
        //    Session["currentUser"] = null;
        //    Session.Abandon();
        //    return RedirectToAction("Index", "Login");
        //}
    }
}