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
                            TempData["Warning"] ="Üyeliğiniz gerçekleşti.Ders içeriklerini incelemek için lütfen giriş yapınız.";
                        }
                        else
                        {
                            TempData["Warning"] = "Aktivasyon kodu daha önce kullanılmıştır";
                        }
                    }
                    else
                    {
                        TempData["Warning"] = "Aktivasyon kodu sistemde tanımlı değildir.Lütfen tekrar kontrol ediniz.";
                    }
                }
            }
            else
            {
                TempData["Warning"] = "Şifreler uyuşmamaktadır. Tekrar kontrol ediniz.";
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            SignUp currentUser = dbContext.SignUp.Where(x => x.UserName == username && x.Password == password).SingleOrDefault();
            if (currentUser != null)
            {
                Session["CurrentUser"] = currentUser;
                TempData["Warning"] = "Giriş başarılı bir şekilde gerçekleşti.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Warning"] = "Kullanıcı adı veya şifre hatalı.. Lutfen tekrar deneyiniz.";
                return View();
            }
        }
    }
}