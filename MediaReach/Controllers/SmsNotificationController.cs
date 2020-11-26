using JUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaReach.Controllers
{
    public class SmsNotificationController : Controller
    {
        // GET: SmsNotification
        public ActionResult Index()
        {
            var transactionType = new List<MyItem>{
                new MyItem{Id = "D", Name = "Debit"},
                new MyItem{Id = "C", Name = "Credit"},//2 and 3
                new MyItem{Id = "B", Name = "Both"},
            };
            var alertBy = new List<MyItem>{
                new MyItem{Id = "S", Name = "SMS"},
                new MyItem{Id = "M", Name = "Mail"},//2 and 3
                new MyItem{Id = "B", Name = "Both"},
            };

            ViewBag.TransactionType = new SelectList(transactionType, "Id", "Name");
            ViewBag.AlertBy = new SelectList(alertBy, "Id", "Name");
            return View();
        }
    }
}