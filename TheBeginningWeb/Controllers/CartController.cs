using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheBeginningWeb.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Items()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Confirmation()
        {
            return View();
        }
    }
}