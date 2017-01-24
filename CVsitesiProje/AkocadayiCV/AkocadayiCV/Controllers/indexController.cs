using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Text;
using AkocadayiCV.Models;
using System.Net.Mail;

namespace AkocadayiCV.Controllers
{
    public class indexController : Controller
    {
        //
        // GET: /index/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisimModel model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("İsim: " + model.adi);
                body.AppendLine("Soyisim: " + model.soyadi);
                body.AppendLine("Telefon: " + model.telefon);
                body.AppendLine("Eposta: " + model.email);
                body.AppendLine("Cinsiyet: " + model.cins);
                body.AppendLine("Askerlik: " + model.askerlik);
                body.AppendLine("Okul: " + model.okul);
                body.AppendLine("Tecrübe: " + model.tecrube);
                body.AppendLine("Yabancı Dil: " + model.ydil);
                body.AppendLine("Pozisyon: " + model.pozisyon);
                body.AppendLine("Ek Mesaj: " + model.text);
                gmail.SendMail(body.ToString());
                ViewBag.Success = true;
            }
            return View();
        }       

    }
}
