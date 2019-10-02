using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPrvi.Models
{
    public class Korisnik
    {
        public static int IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Sifra { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public int PostanskiBroj { get; set; }
        //public int idKorpa { get; set; }
       // public int idWish { get; set; }
        public Korpa Korpa { get; set; }
        public Wish Wish { get; set; }
        public List<Narudzba> Narudzbe { get; set; }

        public Korisnik(string ime, string prezime, string username, string sifra, string email, string adresa, string telefon, string drzava, string grad, int postanskiBroj)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Sifra = sifra;
            this.Email = email;
            this.Adresa = adresa;
            this.Telefon = telefon;
            this.Drzava = drzava;
            this.Grad = grad;
            this.PostanskiBroj = postanskiBroj;
            this.Korpa = new Korpa();
            this.Wish = new Wish();
            this.Narudzbe = new List<Narudzba>();
            IdKorisnik++;
        }
    }
}