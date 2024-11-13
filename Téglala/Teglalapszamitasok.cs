using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Téglalap
{
    class Teglalapszamitasok
    {
        protected double Aoldal,
            Boldal,
            Terulet,
            Kerulet;

        public Teglalapszamitasok()
        {

        }
        public  Teglalapszamitasok(double a, double b)
        {
            this.Aoldal = a;
            this.Boldal = b;
        }
        //Metódusok
        public void ReadAoldal(double aoldal)
        {
            this.Aoldal = aoldal;
        }
        public void ReadBoldal(double boldal)
        {
            this.Boldal = boldal;
        }
        public double  GetAoldal()
        {
            return this.Aoldal;
        }
        public double GetBoldal()
        {
            return this.Boldal;
        }
        //Terület kiszámítása
        public void TeruletSzam()
        {
            this.Terulet = this.Aoldal * this.Boldal;
        }
        public void KeruletSzam()
        {
            this.Kerulet = (this.Aoldal + this.Boldal)*2;
        }
        public double GetKerulet() { return Kerulet; }
        public double GetTerulet() { return Terulet; }


    }
}
