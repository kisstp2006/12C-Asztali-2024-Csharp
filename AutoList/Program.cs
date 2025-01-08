using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AutoList
{
    class Program
    {

        static void Main(string[] args)
        {
            // A jarmuvek listaja
            List<JarmuClass> jarmuvek = new List<JarmuClass>();

            // Adja meg a file nevét
            Console.Write("Kérem adja meg a fájl nevét: ");
            string fileName = Console.ReadLine();
            //Kiserlet a file beolvasására

            try
            {
                Beolvas(fileName, jarmuvek);
                Console.WriteLine("\nAdatok sikeresen beolvasva.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt a fájl beolvasása során: " + ex.Message);
                return;
            }
            // Kiíratás táblázatos formában
            Console.WriteLine("\nA beolvasott adatok:");
            Kiir(jarmuvek);

            Console.ReadKey();
        }

        private static void Beolvas(string fileName, List<JarmuClass> jarmuvek)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Sorok feldolgozása és oszlopokra bontása
                    string[] adatok = line.Split(';');

                    if (adatok.Length == 6)
                    {
                        string rendszam = adatok[0].Trim();
                        string gyartmany = adatok[1].Trim();
                        string tipus = adatok[2].Trim();
                        int gyartasiEv = int.Parse(adatok[3].Trim());
                        DateTime muszakiVizsga = DateTime.Parse(adatok[4].Trim());
                        string tulajdonos = adatok[5].Trim();

                        // Új jármű példány hozzáadása a listához
                        jarmuvek.Add(new JarmuClass(rendszam, gyartmany, tipus, gyartasiEv, muszakiVizsga, tulajdonos));
                    }
                }
            }
        }

        private static void Kiir(List<JarmuClass> jarmuvek)
        {
            // Fejléc kiírása
            Console.WriteLine($"{"Rendszám",-10} | {"Gyártmány",-10} | {"Típus",-10} | {"Év",-4} | {"Műszaki vizsga",-15} | {"Tulajdonos"}");
            Console.WriteLine(new string('-', 80));

            // Járművek kiírása
            foreach (var jarmu in jarmuvek)
            {
                Console.WriteLine(jarmu.ToString());
            }
        }

        }
    }

