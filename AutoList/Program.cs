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
            // A járművek listája
            List<JarmuClass> jarmuvek = new List<JarmuClass>();

            // Fájl beolvasása
            Console.Write("Kérem adja meg a fájl nevét: ");
            string fileName = Console.ReadLine();

            Console.WriteLine($"A megadott fájl neve: {fileName}");  // Ellenőrizzük, hogy mit adtunk meg

            try
            {
                Beolvas(fileName, jarmuvek);
                if (jarmuvek.Count > 0)
                {
                    Console.WriteLine("\nAdatok sikeresen beolvasva.");
                }
                else
                {
                    Console.WriteLine("\nNem olvasható be adat a fájlból.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt a fájl beolvasása során: " + ex.Message);
            }

            // Kiíratás táblázatos formában
            Console.WriteLine("\nA beolvasott adatok:");
            Kiir(jarmuvek);

            Console.ReadKey();
        }


        // Beolvasás metódus
        static void Beolvas(string fileName, List<JarmuClass> jarmuvek)
        {
            // Ellenőrizzük, hogy a fájl létezik-e
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"A fájl nem található: {fileName}");
                return;
            }

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Ha üres sort olvasunk be, azt hagyjuk ki
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    Console.WriteLine($"Beolvasott sor: {line}");  // Kiírjuk a beolvasott sort

                    string[] adatok = line.Split(';');

                    if (adatok.Length == 6)
                    {
                        string rendszam = adatok[0].Trim();
                        string gyartmany = adatok[1].Trim();
                        string tipus = adatok[2].Trim();
                        int gyartasiEv = int.Parse(adatok[3].Trim());
                        DateTime muszakiVizsga = DateTime.Parse(adatok[4].Trim());
                        string tulajdonos = adatok[5].Trim();

                        // Új jármű hozzáadása a listához
                        jarmuvek.Add(new JarmuClass(rendszam, gyartmany, tipus, gyartasiEv, muszakiVizsga, tulajdonos));
                    }
                    else
                    {
                        Console.WriteLine($"Hibás adat: {line}");  // Hibás sorok jelzése
                    }
                }
            }
        }


        // Kiírás metódus
        static void Kiir(List<JarmuClass> jarmuvek)
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

