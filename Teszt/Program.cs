using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            int Összeg = 0;
            List<int> paros = new List<int>() {  };
            List<int> paratlan = new List<int>() {  };


            //Teszt 
            while (Összeg<100) { 
                Console.WriteLine("Adjon meg számokat addig ameddig az összegük nem éri el a 100 at");
                var szam = int.Parse(Console.ReadLine());
                if (szam!=null) //Hogyha semmit nem írunk be nem fut le a program mivel rendes inputra vár
                {
                Console.WriteLine("A jelenleg megadott szám: "+szam.ToString());
                    if (szam % 2 == 0)
                    {
                        paros.Add(szam);
                    }
                    else
                    {
                        paratlan.Add(szam);
                    }
                Összeg += szam;
                Console.WriteLine("Az eddigi összeg: "+Összeg);
                    if (Összeg >= 100)
                    {
                        Console.WriteLine("Az eddigi összeg több mint 100: " + Összeg);
                        for (int i =0; i < paros.Count; i++ )
                        {
                            Console.WriteLine("Páros számok: "+ paros[i]);
                        }
                        for (int i = 0; i < paratlan.Count; i++)
                        {
                            Console.WriteLine("Páratlan számok: " + paratlan[i]);
                        }
                        Console.ReadKey();
                        break;
                    }
                    
                }
            }

            Console.WriteLine("Szia, Hello világ");
        }
    }
}
