using Captcha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;

namespace Captcha.Controllers
{
    public class CaptchaController : Controller
    {
        // GET: Captcha
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration registration)
        {
            if (this.IsCaptchaValid("Captcha geçerlidir"))
            {
                ViewBag.Message = "Capctha geçerli, giriş başarılı";
            }
            else
            {
                ViewBag.Message = "Captcha geçersiz, giriş başarısız";
            }
            return View();
        }
    }
}