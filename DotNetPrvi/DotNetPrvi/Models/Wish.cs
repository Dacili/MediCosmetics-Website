using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPrvi.Models
{
    public class Wish
    {
        public static int IdWish { get; set; }
        public List<Proizvod> ProizvodiWish { get; set; }

        public Wish()
        {//kreirat ce se kada se wisha prvi artikl
            //this.proizvodiWish 
            IdWish++;
        }
    }
}