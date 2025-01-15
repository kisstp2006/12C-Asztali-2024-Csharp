using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformoop
{
    class Haz
    {
        private List<Nber> nbers = new List<Nber>();
        public void hazajon(Nber obj)
        {
            this.nbers.Add(obj);

        }
        public void csenget()
        {
            int i;
            Random rd = new Random();
            if (nbers.Count >0)
            {
                i = rd.Next(0, nbers.Count - 1);
                Console.WriteLine(nbers[i].beszel());
            }
        }
    }
}
