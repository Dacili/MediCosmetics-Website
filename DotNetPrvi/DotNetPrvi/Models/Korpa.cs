using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPrvi.Models
{
    public class Korpa
    {
        public static int IdKorpa { get; set; }
        public double UkupnaCijena { get; set; }
        public double Postarina { get; set; }
        public Tuple<Proizvod, int> ProizvodiKorpa { get; set; }

        public Korpa()
        {
            //proizvodi korpa cemo kreirati kada doda prvi artikl
            //this.proizvodiKorpa = new Tuple<Proizvod, int>();
            this.Postarina = 0;
            this.UkupnaCijena = 0;
            IdKorpa++;
        }
    }
}