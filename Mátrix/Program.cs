using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrix
{
    class MatrixN
    {
        //Class viariables
        string bemenet;
        string[] listabemenet; // létrehozom a listát a számokhoz
        int[] bemenetlista;

        public MatrixN()
        {

        }
        public void Matrixbekeres()
        {
            Console.WriteLine("Adjon meg egy Tetszőleges méretű NxN Mátrixot");
            int NxN = Convert.ToInt32(Console.ReadLine());  // Az első érték 0 
            int[,] lista = new int[NxN, NxN];
            for (int i=0; i< NxN; i++)
            {

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Példányosítjuk az osztályt (objektum létrehozása az osztálybol)
            var MatrixObj = new MatrixN();
            Console.WriteLine("Mátrix");
            MatrixObj.Matrixbekeres();
            Console.ReadKey();
            
        }
    }
}
