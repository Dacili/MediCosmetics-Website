using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace DotNetPrvi.Models
{
    public class Proizvod
    {
        public static int IdProizvod { get; set; }
        public string BojaBadge { get; set; }
        public string TekstBadge { get; set; }
        //public Image Slika { get; set; }
        public string PutanjaDoSlike { get; set; }
        public string Naziv { get; set; }
        public double CijenaNova { get; set; }
        public double CijenaStara { get; set; }
        public int BrKomadaNaStanju { get; set; }
        public string Cijena { get; set; }

        public Proizvod(string bojaBadge, string tekstBadge, Image slika, string naziv, double cijenaNova, int brKomadaNaStanju)
        {
            this.BojaBadge = bojaBadge;
            this.TekstBadge = tekstBadge;
            //this.Slika = slika;
            this.Naziv = naziv;
            this.CijenaNova = cijenaNova;
            this.CijenaStara = cijenaNova;
           
            this.BrKomadaNaStanju = brKomadaNaStanju;
            IdProizvod++;
        }

        public Proizvod(string bojaBadge, string tekstBadge, string putanja, string naziv, string cijena, int brKomadaNaStanju)
        {
            this.BojaBadge = bojaBadge;
            this.TekstBadge = tekstBadge;
           this.PutanjaDoSlike = putanja;
            this.Naziv = naziv;
            this.Cijena = cijena;
            

            this.BrKomadaNaStanju = brKomadaNaStanju;
            IdProizvod++;
        }
        //public string dostupneBoje { get; set; }






    }
}