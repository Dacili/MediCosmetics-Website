using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetPrvi.Models;
using System.Drawing;


namespace DotNetPrvi.Controllers
{
    public class SalesController : Controller
    {
       // [Route("sales/index")]
        // GET: Sales
        public ActionResult Index()
        {
            ParentZaSve parent = new ParentZaSve();
            Image slika = Image.FromFile("C:/Users/dinam/OneDrive/Desktop/self taught/dotNet/DotNetPrvi/DotNetPrvi/Photos/usne/dreamLipsLiner1.PNG");
            //parent.Proizvodi.Add(new Proizvod("info", "new", Image.FromFile(DotNetPrvi.Photos.matte1.PNG), "Dream lips liner", 6.50, 50));

            // parent.Proizvodi.Add(new Proizvod("info", "new", Image.FromFile("C:/Users/dinam/OneDrive/Desktop/self taught/dotNet/DotNetPrvi/DotNetPrvi/Photos/usne/dreamLipsLiner1.PNG"), "Dream lips liner", 6.50, 50));
            string putanja = "./Photos/usne/dreamLipsLiner1.PNG";
            parent.Proizvodi.Add(new Proizvod("info", "new", putanja, "Dream lips liner", "6.50", 50));
            //slika = Image.FromFile("C:/Users/dinam/OneDrive/Desktop/self taught/dotNet/DotNetPrvi/DotNetPrvi/Photos/usne/dreamLipsLiner2.PNG");
            putanja = "./Photos/usne/dreamLipsLiner2.PNG";
            parent.Proizvodi.Add(new Proizvod("sale", "new", putanja, "Dream lips liner", "6.50", 50));
            // slika = Image.FromFile("C:/Users/dinam/OneDrive/Desktop/self taught/dotNet/DotNetPrvi/DotNetPrvi/Photos/usne/dreamLipsLiner3.PNG");
            putanja = "./Photos/usne/dreamLipsLiner3.PNG";
            parent.Proizvodi.Add(new Proizvod("info", "new", putanja, "Dream lips liner", "6.50", 50));


            //matte
            putanja = "./Photos/usne/matte1.PNG";
            parent.Proizvodi.Add(new Proizvod("info", "new", putanja, "Matte lipstick", "7.50", 50));

            putanja = "./Photos/usne/matte2.PNG";
            parent.Proizvodi.Add(new Proizvod("info", "new", putanja, "Matte lipstick", "7.50", 50));


            putanja = "./Photos/usne/matte3.PNG";
            parent.Proizvodi.Add(new Proizvod("info", "sale", putanja, "Matte lipstick", "6.50", 50));

            //velvet
            putanja = "./Photos/usne/velvetMatte1.PNG";
            parent.Proizvodi.Add(new Proizvod("danger", "new", putanja, "Velvet matte lipstick", "7.50", 50));

            putanja = "./Photos/usne/velvetMatte2.PNG";
            parent.Proizvodi.Add(new Proizvod("danger", "new", putanja, "Velvet matte lipstick", "7.50", 50));


            putanja = "./Photos/usne/velvetMatte3.PNG";
            parent.Proizvodi.Add(new Proizvod("danger", "sale", putanja, "Velvet matte lipstick", "6.50", 50));








            return View(parent);
        }
    }
}