using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPrvi.Models
{
    //static class kako bi mogla pristupiti odakle god bez kreiranja instance
    public  class ParentZaSve
    {
        public List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();
        public   List<Narudzba> Narudzbe { get; set; } = new List<Narudzba>();
        public  List<Proizvod> Proizvodi { get; set; } = new List<Proizvod>();
        public   List<Korpa> Korpe { get; set; } = new List<Korpa>();
        public  List<Wish> Wishes { get; set; } = new List<Wish>();

        //I recommend that you do this, this will reduce the amount of code, do the same in other models using the example, while leaving the default constructor implicitly.

    }

}