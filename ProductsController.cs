using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using new_1;
using new_1.Models;

namespace new_1.Controllers
{
    public class ProductsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
