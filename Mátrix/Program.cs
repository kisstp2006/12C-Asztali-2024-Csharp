using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int méret; // a mátrix méretét ebben táruljuk
            Console.WriteLine("Adja meg a mátrix méretét");
            if (!int.TryParse(Console.ReadLine(), out méret)) //Méret bekérése és kiadása/kiküldése
            {
                Console.WriteLine("A megadott méret nem egy szám érték");
                Console.WriteLine("Nyomja meg az ESC gombot a kilépéshez");
                while (Console.ReadKey().Key != ConsoleKey.Escape) { } // Hogyha az Escape gombot akármikor megnyomjuk akkor záruljon be a program
                return;
            }

            int[,] matrix = new int[méret, méret];  //Mátrix méretének listába helyezése 1. a számok mennyisége 2. a sorok száma

            for (int i = 0; i < méret; ++i)
            {
                bool complete = false; 
                while (!complete)// figyeljük hogy ki van e töltve a mátrix
                {
                    Console.WriteLine(string.Format("[{0}] - Írjon be {1} számot(SPACE-el elkülönítve):", i, méret));
                    string[] input = Console.ReadLine().Split(' '); //A bevitt számokat a SPACE eknél válasszuk el
                    if (input.Count() != méret)
                    {
                        Console.WriteLine("The input was invalid, try again...");
                        continue;
                    }
                    for (int j = 0; j < méret; ++j)
                    {
                        if (!int.TryParse(input[j], out matrix[i, j]))
                        {
                            complete = false;
                            Console.WriteLine("The input was invalid, try again...");
                            break;
                        }
                        complete = true;
                    }

                }
            }
            Console.WriteLine("Kimenet: \n");
            Matrixkiírása(matrix, méret);
            Console.ReadKey();
        }

        private static void Matrixkiírása(int[,] matrix, int size)
        {
            string output = string.Empty;
            for (int i = 0; i < size; ++i)
            {
                string line = string.Empty;
                for (int j = 0; j < size; ++j)
                    line += string.Format("{0} ", matrix[i, j]);
                output += string.Format("{0}\n", line.Trim());
            }
            Console.WriteLine(output);
        }

    }
}
