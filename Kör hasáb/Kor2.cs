using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kör_hasáb
{
    class Kor2
    {
        //Osztaly változó
        private double sugar, kerulet, terulet;

        public Kor2()
        {
            
        }
        public Kor2(double r)
        {
            this.sugar = r;
            Szamitások();

        }
        public void SetSugar(double r)
        {
            this.sugar = r;
            Szamitások();

        }
        private void CalcKerulet()
        {
           this.kerulet= 2* this.sugar * Math.PI;
        }
        private double Calcterulet(double r)
        {

            return Math.Pow(this.sugar, 2) * Math.PI; ;
        }
        private void Szamitások()
        {
            CalcKerulet();
            this.terulet = Calcterulet(this.sugar);
        }
    }
}
