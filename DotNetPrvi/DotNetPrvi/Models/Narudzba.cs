using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPrvi.Models
{
    public class Narudzba
    {
        public static int IdNarudzba { get; set; }
        public Tuple<Proizvod, int> ProizvodiNaruzdba { get; set; }
        public int IdKorisnik { get; set; }

      
        public Narudzba(Tuple<Proizvod, int> proizvodiNaruzdba, int idKorisnik)
        {
            this.ProizvodiNaruzdba = proizvodiNaruzdba;
            this.IdKorisnik = idKorisnik;
            IdNarudzba++;
        }
    }
}