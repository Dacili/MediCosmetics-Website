using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPrvi.Models
{
    //static class kako bi mogla pristupiti odakle god bez kreiranja instance
    public  class ParentZaSve
    {
        public  List<Korisnik> Korisnici { get; set; }
        public   List<Narudzba> Narudzbe { get; set; }
        public  List<Proizvod> Proizvodi { get; set; }
        public   List<Korpa> Korpe { get; set; }
        public  List<Wish> Wishes { get; set; }

        
        public ParentZaSve()
        {
            Korisnici = new List<Korisnik>();
            Narudzbe = new List<Narudzba>();
            Proizvodi = new List<Proizvod>();
            Korpe = new List<Korpa>();
            Wishes = new List<Wish>();
        }
        
    }
    
}