using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using DataFactoryMr;
using DataFactoryMr.Models;
using JUtility;
using OfficeOpenXml.ConditionalFormatting;

namespace MediaReach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "SmsNotification");
        }

    }

}