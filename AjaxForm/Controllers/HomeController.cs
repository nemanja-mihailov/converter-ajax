using AjaxForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxForm.Controllers
{
    public partial class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View(new CoModel());
        }
        [HttpPost]
        public double ConvertToEuro(CoModel coModel)
        {
            double euro = coModel.broj / 118;
            return euro;
        }

        [HttpPost]
        public double ConvertToDinar(CoModel coModel)
        {
            double dinar = coModel.broj * 118;
            return dinar;
        }
    }
}