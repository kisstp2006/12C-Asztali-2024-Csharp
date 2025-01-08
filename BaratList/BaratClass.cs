using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratList { 

    public class BaratClass
    {
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public string Nem { get; set; }
        public int BulizasiHajlam { get; set; }

        // Konstruktor
        public BaratClass(string nev, DateTime szuletesiDatum, string nem, int bulizasiHajlam)
        {
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            Nem = nem;
            BulizasiHajlam = bulizasiHajlam;
        }
    }

}
