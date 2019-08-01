using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YetimPro.Models;

namespace YetimPro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sorularınızı Bize Sorun, Dönüş Yapalım.";

            return View();
        }

        [HttpPost]//post işleminde çalışıyor.
        public ActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)//hata var mı kontrol ediyor dataanationda.
            {
                try
                {
                    System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();

                    mailMessage.From = new System.Net.Mail.MailAddress("sehelcigdem@gmail.com", "Sehel KESKİN");
                    mailMessage.Subject = "İletişim Formu: " + model.Ad + " ";

                    mailMessage.To.Add("sehelcigdem@gmail.com");
                    string body;
                    body = "Ad Soyad: " + model.Ad + " " + model.Soyad + "<br />";
                    body += "E-posta: " + model.Email + "<br />";
                    body += "Telefon: " + model.Tel + "<br />";
                    body += "Mesaj: " + model.Mesaj+ "<br />";
                    body += "Tarih: " + DateTime.Now.ToString("dd MMMM yyyy") + "<br />";
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = body;

                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new System.Net.NetworkCredential("sehelcigdem@gmail.com", "Allah123");
                    smtp.EnableSsl = true;
                    smtp.Send(mailMessage);
                    ViewBag.Message = "Mesajınız gönderildi. Teşekkür ederiz.";

                }
                catch
                {
                    ViewBag.Error = "Form gönderimi başarısız oldu tekrar deneyiniz.";

                }
            }
            return View(model);
        }

        public ActionResult Bagis()
        {
            var bagis = new BagisSinif();
            return View(bagis);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Bagis(BagisSinif bagiss)
        {
            if (ModelState.IsValid)
            {

                using (var db = new ApplicationDbContext())
                {
                    db.BagisSinif.Add(bagiss);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(bagiss);
        }

        public ActionResult Blog()
        {
            using (var db=new ApplicationDbContext())
            {
                var haber = db.Habers.ToList();

               return View(haber);  }

        }

        public ActionResult Kisi1()
        {
            using (var db = new ApplicationDbContext())
            {

                var yorum = db.Comments.ToList();
                return View(yorum);
            }
        
              
        }

        [HttpPost]
        public ActionResult Kisi1(Comment comment,string Namee, string Messagee)
        {

            if (ModelState.IsValid)
            {
             
                    using (var db = new ApplicationDbContext())
                    {

                        var yorum = new Comment();
                        yorum.Ad = Namee;
                        yorum.Mesaj = Messagee;
                        yorum.Tarih = DateTime.Now;
                        yorum.HaberId = 3;
                        db.Comments.Add(yorum);
                        db.SaveChanges();
                        return RedirectToAction("Kisi1");
                    
                    }

             
            }
            return View(comment);
        }

        public ActionResult Kisi2()
        {
            using (var db = new ApplicationDbContext())
            {
                var yorum = db.Comments.ToList();
                return View(yorum);
                //ViewBag.Comments = db.Comments.ToList();
                //return View();
            }
        }

        [HttpPost]
        public ActionResult Kisi2(Comment comment,string Namee,string Messagee)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ApplicationDbContext())
                {

                    var yorum = new Comment();
                    yorum.Ad = Namee;
                    yorum.Mesaj = Messagee;
                    yorum.Tarih = DateTime.Now;
                    yorum.HaberId = 7;
                    db.Comments.Add(yorum);
                    db.SaveChanges();
                    return RedirectToAction("Index");  
                }
            }
            return View(comment);
        }

    }
}