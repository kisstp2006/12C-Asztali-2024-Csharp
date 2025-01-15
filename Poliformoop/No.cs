using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformoop
{
    class No : Nber
    {
        public string SzemSzin { get; set; }
        public No (string nev ,string szemszing):
            base(nev)
        {
            SzemSzin = szemszing;
        }
    }
}
