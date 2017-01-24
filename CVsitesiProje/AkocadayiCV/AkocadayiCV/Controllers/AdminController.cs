using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkocadayiCV.Models;

namespace AkocadayiCV.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        CvDbDataContext vt = new CvDbDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(FormCollection frm)
        {
            string kullaniciAdi = frm.Get("txtKullaniciAdi").Trim();
            string sifre = frm.Get("txtSifre").Trim();
            if (kullaniciAdi == "" || sifre == "")
            {
                ViewBag.Bos = true;
            }
            else
            {
                CvDbDataContext vt = new CvDbDataContext();
                var kayit = from k in vt.yoneticilers where k.kullaniciAdi == kullaniciAdi && k.Sifre == sifre select new { k.ID };
                if (kayit.ToList().Count > 0)
                {
                    Session.Add("giris", true);
                    foreach (var item in kayit)
                    {
                        Session.Add("id", item.ID);
                    }
                    return RedirectToAction("index");
                }
                else
                {
                    ViewBag.onay = false;
                }
            }
            return View();
        }
        private String UrlTemizle(string data)
        {
            data = data.Replace(",", "").Replace("\"", "").Replace("'", "").Replace(":", "").Replace(";", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(")", "").Replace("(", " ").Replace("&", " ").Replace(" ", " ");
            return data;
        }
        public ActionResult kategoriekle()
        {
            
            if (Request.HttpMethod == "POST")
            {
                string katadi = Request.Form.Get("txtKategoriAdi").Trim();
                if (katadi == "")
                {
                    ViewBag.bos = true;
                }
                else
                {
                    var result = from k in vt.kategorilers where k.kategoriAdi == katadi select new { k.ID };
                    if (result.ToList().Count>0)
                    {
                        ViewBag.var = true;
   
                    }
                    else
                    {

                    
                    string urlKat = UrlTemizle(katadi);
                    
                    kategoriler k = new kategoriler
                    {
                        kategoriAdi = katadi,
                        urlsefKatAdi = urlKat
                    };
                    vt.kategorilers.InsertOnSubmit(k);
                    vt.SubmitChanges();
                    ViewBag.eklendi = true;
                    }
                }
                }
                return View();
                
            }
        public ActionResult kategoriList()
    {
        return View(vt.kategorilers.ToList());
    }
        public ActionResult kategoriDuzenle(int id)
        {
            kategoriler k = vt.kategorilers.First(m=>m.ID==id);
            return View(k);
        }
        [HttpPost]
        public ActionResult kategoriDuzenle(kategoriler k)
        {
            if (ModelState.IsValid)
            {
                var result = from kat in vt.kategorilers where kat.ID == k.ID select kat;
                foreach (var item in result)
                {
                    item.kategoriAdi=k.kategoriAdi;
                    item.urlsefKatAdi=k.urlsefKatAdi;
                }
                vt.SubmitChanges();
                return View("Basarili",k);
            }
            return View();
        }
        public ActionResult Basarili()
    {
        return View();
    }
        public ActionResult kategorisil(int id)
        {
            kategoriler k = vt.kategorilers.First(x=>x.ID==id);
            return View(k);
        }
        [HttpPost]
        public ActionResult kategorisil (kategoriler k)
        {
            kategoriler katSil = vt.kategorilers.First(x=>x.ID==k.ID);
            vt.kategorilers.DeleteOnSubmit(katSil);
            vt.SubmitChanges();
            return RedirectToAction("kategorilist");
        }
        public void kategoriler()
        {
            List<SelectListItem> kategorilerlist = new List<SelectListItem>();
            var kategorilersorgu = from k in vt.kategorilers select k;
            foreach (var item in kategorilersorgu)
            {
                kategorilerlist.Add(new SelectListItem{Text=item.kategoriAdi,Value=item.ID.ToString()});
            }
            ViewBag.kategoriler = kategorilerlist;
        }
        public void yazarlar()
        {
            List<SelectListItem> yazarlarlist = new List<SelectListItem>();
            var kategorilersorgu = from k in vt.yoneticilers select new {k.adi,k.ID };
            foreach (var item in kategorilersorgu)
            {
                yazarlarlist.Add(new SelectListItem { Text = item.adi, Value = item.ID.ToString() });
            }
            ViewBag.yazarlar = yazarlarlist;
        }
        public ActionResult MakaleEkle()
        {
            kategoriler();
            yazarlar();
            return View();
        }
        [HttpPost,ValidateInput(false)]
        public ActionResult MakaleEkle(FormCollection frm)
        {
            kategoriler();
            yazarlar();
            string makaleAdi = frm.Get("makaleAdi");
            int katid = Convert.ToInt32(frm.Get("kategoriler"));
            string makaleKisaAciklama = frm.Get("makaleKisaAciklama");
            string makale = frm.Get("makale");
            string makaleKeyword = frm.Get("makaleKeyword");
            string makaleDescriptiom = frm.Get("makaleDescription");
            string makaleTitle = frm.Get("makaleTitle");
            int yazarid = Convert.ToInt32(frm.Get("yazarlar"));
            makaleler makaleekle = new makaleler
            {
                makaleAdi = makaleAdi,
                kategoriID = katid,
                makaleKisaAciklama = makaleKisaAciklama,
                makale = makale,
                makaleKeyword = makaleKeyword,
                makaleDescription = makaleDescriptiom,
                makaleTitle = makaleTitle,
                yazarID = yazarid
            };
            return View();
        }
        public ActionResult Makalaler()
        {
            var makaleQuery=from m in vt.makalelers join k in vt.kategorilers on m.kategoriID equals k.ID join y in vt.yoneticilers on m.yazarID equals y.ID select new{m.ID,m.makaleAdi,m.makaleDescription,m.makaleKeyword,m.makaleKisaAciklama,m.makaleTitle,m.makale,k.kategoriAdi,y.adi};
            List<makaleHelper> mlist = new List<makaleHelper>();
            foreach (var item in makaleQuery)
            {
                makaleHelper makale = new makaleHelper();
                makale.makaleID = item.ID;
                makale.makaleAdi = item.makaleAdi;
                makale.makaleDescription = item.makaleDescription;
                makale.makaleTitle = item.makaleTitle;
                makale.makaleKisaAciklama = item.makaleKisaAciklama;
                makale.yazarAdi = item.adi;
                makale.makale = item.makale;
                makale.kategoriAdi = item.kategoriAdi;
                makale.makaleKeyword = item.makaleKeyword;
                mlist.Add(makale);
               
            }
            ViewBag.makaleList = mlist;
            return View(mlist);
        }
        }
    }
