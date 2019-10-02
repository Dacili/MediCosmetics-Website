using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetPrvi.Models;
namespace DotNetPrvi.Controllers
{
    public class ShopAllController : Controller
    {
        // GET: ShopAll
        public ActionResult Index()
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            return View();
        }
    }
}