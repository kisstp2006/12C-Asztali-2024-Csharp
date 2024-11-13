using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Téglalap
{
    class Téglatest : Teglalapszamitasok
    {
        private double
            Coldal,
            terfogat,
            felszin;
        public Téglatest()
        {

        }
        public Téglatest(double a, double b,double m)
        {
            this.Coldal = m;
            this.Aoldal = a;
            this.Boldal = b;

        }
        public void ReadColdal(double m)
        {
            this.Coldal = m;
        }
        public double ReturnMagassag()
        {
            return this.Coldal;
        }
        public double ReturnTerfogat()
        {
            return this.terfogat;
        }
        public double Returnfelszin()
        {
            return this.felszin;
        }
        public void TerfogatSzamit()
        {
            this.terfogat = this.Aoldal * this.Boldal * this.Coldal;
        }
        public void FelszinSzamit()
        {
            this.felszin = 2 * (this.Aoldal * this.Boldal + this.Aoldal *this.Coldal+ this.Boldal *this.Coldal);
        }

    }
}
