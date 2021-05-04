using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication5.Models;
using System.Net.Mail;

namespace MvcApplication5.Controllers
{
    public class SimpleEmailController : Controller
    {
        //
        // GET: /SimpleEmail/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Email em)
        {
            string to = em.To;
            string subject = em.Subject;
            string body = em.Body.ToString();
            MailMessage nm = new MailMessage();
            nm.To.Add(to);
            nm.Subject = subject;
            nm.Body = body;
            nm.From = new MailAddress("vishalmestry25@gmail.com");
            nm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.google.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("vishalmestry25@gmail.com","Vaibhavivishal@08");
            smtp.Send(nm);
            ViewBag.message = "The Mail has been sent to"+em.To+"Successfully....";



            return View();

        }

    }
}
