using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication5.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        [AllowHtml]
        public string Body { get; set; }
    }
}