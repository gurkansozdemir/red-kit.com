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
        public ActionResult Index(string username, string password, string passwordagain, string activationCode)
        {
            if (password == passwordagain)
            {
                List<ActivationCode> activationList = dbContext.ActivationCode.ToList();
                foreach (var item in activationList)
                {
                    if (item.Code == activationCode)
                    {
                        if (item.IsActive == false)
                        {
                            SignUp tmp = new SignUp()
                            {
                                ActivationCode = activationCode,
                                CreatedOn = DateTime.Now,
                                Password = password,
                                UserName = username
                            };
                            ActivationCode code = dbContext.ActivationCode.Find(item.ID);
                            code.IsActive = true;
                            dbContext.SignUp.Add(tmp);
                            dbContext.SaveChanges();
                            ViewBag.PopupMessage = "Üyeliğiniz gerçekleşti.";
                        }
                        //else
                        //{
                        //    ViewBag.PopupMessage = "Aktivasyon kodu daha önce kullanılmıştır";
                        //}
                    }
                    else
                    {
                        ViewBag.PopupMessage = "Aktivasyon kodu sistemde tanımlı değildir.Lütfen tekrar kontrol ediniz.";
                    }
                }

            }
            else
            {
                ViewBag.PopupMessage = "Şifreler uyuşmamaktadır. Tekrar kontrol ediniz.";
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}