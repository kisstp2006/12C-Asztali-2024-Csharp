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
        }
    }
}
