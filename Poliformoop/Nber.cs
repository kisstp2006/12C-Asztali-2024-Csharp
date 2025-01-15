using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformoop
{
    class Nber
    {
        public string Nev { get; set; }
        private string bemutat = "SZia a nevem a ku-.";

        public Nber(string nev)
        {
            Nev = nev;
        }
        public string beszel()
        {
            return (bemutat + Nev);
        }
    }
}
