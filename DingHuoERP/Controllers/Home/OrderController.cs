using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DingHuoERP.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /order/

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult OrderCreateNew()
        {
            return View();
        }
    }
}
