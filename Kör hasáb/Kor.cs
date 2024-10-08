﻿using System;
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
        //Konstruktorok
        public Kor()
        {

        }
        public Kor(double r) //a konstruktor nem adhat vissza értéket így nem is kell kifejezni
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
