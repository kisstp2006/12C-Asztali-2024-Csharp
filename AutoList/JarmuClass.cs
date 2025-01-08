using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoList
{
    class JarmuClass
    {
        private string Rendszam { get; set; }
        private string Gyartmany { get; set; }
        private string Típus { get; set; }
        private int Gyartasiév { get; set; }
        private DateTime Muszakivizsgaervenyessege { get; set; }
        private string TulajNeve { get; set; }


        public JarmuClass(string rendszam, string gyartmany, string tipus, int gyartasiEv, DateTime muszakiVizsgaErvenyesseg, string tulajdonosNeve)
        {
            Rendszam = rendszam;
            Gyartmany = gyartmany;
            Típus = tipus;
            Gyartasiév = gyartasiEv;
            Muszakivizsgaervenyessege = muszakiVizsgaErvenyesseg;
            TulajNeve = tulajdonosNeve;
        }
        public override string ToString()
        {
            return  $"{Rendszam,-10} | {Gyartmany,-10} | {Típus,-10} | {Gyartasiév,-4} | {Muszakivizsgaervenyessege.ToShortDateString(),-15} | {TulajNeve}";

        }
    }
}
