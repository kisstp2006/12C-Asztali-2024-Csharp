using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kör_hasáb
{
    class Henger : Kor
    {
        //Osztaly valtozok
        private double magassag ,terfogat;
        public Henger() { }

        public Henger(double r, double m) {
            this.magassag = m;
            this.sugar = r;
            SetTerulet();
            this.terfogat = this.terulet * this.magassag;
        }
        public double GetTerfogat()
        {
            return this.terfogat;
        }
        public double GetMagassag()
        {
            return this.magassag;
        }

    }
}
