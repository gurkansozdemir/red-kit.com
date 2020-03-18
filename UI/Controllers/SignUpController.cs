using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class SignUpController : Controller
    {
        RedKitContext dbContext = new RedKitContext();
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username,string password,string passwordagain,string activationCode)
        {
            if (password==passwordagain)
            {

            }
            else
            {
                //şifreler uyuşmuyor.
            }
            return View();
        }
    }
}