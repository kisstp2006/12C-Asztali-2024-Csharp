using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockak
{
    class NegyszogClass
    {
            private double oldal1, oldal2;
            private double terulet, kerulet;

            // 1. Üres konstruktor
            public NegyszogClass()
            {
                oldal1 = 0;
                oldal2 = 0;
                terulet = 0;
                kerulet = 0;
                Console.WriteLine("Üres konstruktor hívva.");
            }

            // 2. Egy paraméteres konstruktor (négyzet)
            public NegyszogClass(double a)
            {
                oldal1 = a;
                oldal2 = a;
                Console.WriteLine("Egy paraméteres konstruktor (négyzet) hívva.");
                SetTerulet();
                SetKerulet();
            }

            // 3. Két paraméteres konstruktor (téglalap)
            public NegyszogClass(double a, double b)
            {
                oldal1 = a;
                oldal2 = b;
                Console.WriteLine("Két paraméteres konstruktor (téglalap) hívva.");
                SetTerulet();
                SetKerulet();
            }

            // SetOldal1: Egy oldal beállítása (négyzet)
            public void SetOldal1(double a)
            {
                oldal1 = a;
                if (oldal2 == 0) // Ha oldal2 nincs akkor négyzetet feltételezünk
                {
                    oldal2 = a;
                }
                SetTerulet();
                SetKerulet();
            }

            // SetOldal2: Két oldal beállítása (téglalap)
            public void SetOldal2(double a, double b)
            {
                oldal1 = a;
                oldal2 = b;
                SetTerulet();
                SetKerulet();
            }

            // SetTerulet: Terület kiszámítása
            private void SetTerulet()
            {
                terulet = oldal1 * oldal2;
            }

            // SetKerulet: Kerület kiszámítása
            private void SetKerulet()
            {
                kerulet = 2 * (oldal1 + oldal2);
            }

            // GetTerulet: Visszaadja a területet
            public double GetTerulet()
            {
                return terulet;
            }

            // GetKerulet: Visszaadja a kerületet
            public double GetKerulet()
            {
                return kerulet;
            }
        }
    }

