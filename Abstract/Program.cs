using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            /*Ez a példa a Abstract kulcsszó használatát mutatja be 
             *Az Abstract kulcsszóval olyan osztályokat és metódusokat jelölünk amelyeket nem lehet közvetlenül pédányosítani 
             *illetve végrehalytani . Az Abstract osztályokat alapként hasnálják més osztályok számára,
             *míg az Abstract metódusok deklarációkat tartalmaznak, de nem admak meg implementációt
             */

            /* Fontos jellenzők
             * -Az Abstract osztály csak leszármazott osztályokon keresztül használható. Tartalmazhat Abstract és nem Abstract (Működő)osztályokat is
             * -Abstract metódus: Csak Abstract osztályban lehet származtatott osztálynak kötelező megvalósítani.
             */
namespace Abstract
{
    abstract class Shape
    {
        //Abstract metódus - nincs implementáció
        //Ennek a kódjárt a leszármazottban kötelező megírni

        public abstract double GetArea();

        //Normál metódus - van implementáció

        public void DisplayShape()
        {
            Console.WriteLine("Ez egy alakzat");
        }

    }

    class Circle : Shape
    {
        private double Sugar;

        public Circle(double r)
        {
            this.Sugar = r;
        }

        //Abstract metúdis implementálása
        public override double GetArea()
        {
            return Math.PI*Sugar*Sugar;
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            //Shape példányosítása nem lehetséges:
            //Shape shape = new Shape(); //Fordítási hiba
            //Circle példányosítása
            Circle circle = new Circle(5);
            Console.WriteLine("A kör területe:"+circle.GetArea());
            circle.DisplayShape();

            Console.ReadKey();
        }
    }
}
