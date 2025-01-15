using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformoop
{
    class Ferfi : Nber
    {
        public int Kor { get; set; }
         
        public Ferfi(string nev, int kor):
            base(nev)
            {
            Kor = kor;

        }
    }
}
