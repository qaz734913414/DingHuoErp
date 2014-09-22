using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DingHuoERP.Controllers
{
    public class MessageController : Controller
    {
        //
        // GET: /Message/

        public ActionResult Notification()
        {
            return View();
        }

    }
}
