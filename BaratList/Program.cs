using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratList
{
    class Program
    {
        public static void Beolvas(string fileName, List<BaratClass> baratok)
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
                    if (string.IsNullOrWhiteSpace(line)) continue; // Üres sorok figyelmen kívül hagyása

                    Console.WriteLine($"Beolvasott sor: {line}");  // Kiírjuk a beolvasott sort

                    string[] adatok = line.Split(',');

                    if (adatok.Length == 4)
                    {
                        string nev = adatok[0].Trim();
                        DateTime szuletesiDatum = DateTime.Parse(adatok[1].Trim());
                        string nem = adatok[2].Trim();
                        int bulizasiHajlam = int.Parse(adatok[3].Trim());

                        baratok.Add(new BaratClass(nev, szuletesiDatum, nem, bulizasiHajlam));
                    }
                    else
                    {
                        Console.WriteLine($"Hibás adat: {line}");  // Hibás sorok jelzése
                    }
                }
            }
        }

        // Adatok kiírása táblázatos formában
        public static void Kiir(List<BaratClass> baratok)
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-10} {3,-10}", "Név", "Születési Dátum", "Nem", "Bulizási Hajlam");
            Console.WriteLine("-------------------------------------------------------------");

            foreach (var barat in baratok)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-10} {3,-10}",
                    barat.Nev,
                    barat.SzuletesiDatum.ToString("yyyy-MM-dd"),
                    barat.Nem,
                    barat.BulizasiHajlam);
            }
        }

        static void Main(string[] args)
        {
            List<BaratClass> baratok = new List<BaratClass>();

            // Fájl beolvasása
            Console.Write("Kérem adja meg a fájl nevét: ");
            string fileName = Console.ReadLine();

            Beolvas(fileName, baratok);
            if (baratok.Count > 0)
            {
                Console.WriteLine("\nAdatok sikeresen beolvasva.");
            }
            else
            {
                Console.WriteLine("\nNem olvasható be adat a fájlból.");
            }

            // Kiíratás táblázatos formában
            Console.WriteLine("\nA beolvasott adatok:");
            Kiir(baratok);

            Console.ReadKey();
        }

    }
}
