using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kör_hasáb
{
    /*Az osztály feladata a sugárból kiszámítja a kör területét és kerületét*/
    class Kor
    {
        //Osztály adatok
        private double sugar,
            kerulet,
            terulet;
        //Konstruktorok szerepe : az osztályból példányt hoz lére , önmagában az osztállyal nem tudunk dolgozni , a kontruktorok végzik el a példányosítást, több konstruktor is lehet , a program tudja hogy melyik konstruktort kell használni
        /*
        Egységbe zárás: Az objektum / osztálynak a változóihoz csak ellenörzötten férek hozzá
        Paraméter lista: Formális paraméter: Deklarációban szerepel. Aktuális paraméter: Mikor a paraméter értéket kap. 
         */
        public Kor() 
        {

        }
        public Kor(double r) //a konstruktor (létrehoz) nem adhat vissza értéket így nem is kell kifejezni Konstruktor A kontruktoz az amely az osztályt egy objektummá alakítja
        {
            this.sugar = r;
        }
        //Metódusok
        public void ReadSugar(double r)
        {
            this.sugar = r;
        }
        public void SetKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }
        public void SetTerulet()
        {
            double eredmeny1, eredmeny2 = 0.00;
            eredmeny1 = this.sugar * this.sugar * Math.PI;

            eredmeny2 = Math.Pow(this.sugar, 2) * Math.PI;                                                                                                                                                                                                     //na
            if (eredmeny1 == eredmeny2)
            {
                this.terulet = eredmeny2;
            }
            else
            {
                Console.Write($"eredmeny 1 {eredmeny1} nem egyenlő eredmény 2 vel {eredmeny2}");
            }
        }
        public double GetKerulet()
        {
            return this.kerulet;
        }
        public double GetTerulet()
        {
            return this.terulet;
        }
        public double GetSugar()
        {
            return this.sugar;
        }
        
    }
}
