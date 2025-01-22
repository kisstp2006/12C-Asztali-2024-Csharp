using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Példa a következőre:
             * virtual , override
             * A virtual kulcszo azt jelzi hogy egy metódus vagy property felül írható egy leszármazott osztályban A virtual tagok alapártelmezett viselkedést biztosítanak az ős osztálybanm de a származtatott osztályban az override kulcszóval módosíthatjuk euz a viselkedést
             * sealed
             *A sealed kulcsszó lezárja az osztályokat vagy metódusokat a további öröklődéstől vagy felilírástól , ezáltal biztosítva a stabilitást és a logikai változtatlanségot a kódbázisban
            */

            //Atlag osztaly

        }
        class Allat
        {
            //Properties
            public string Name { get; set; }
            public string Hang { get; set; }
            //Konstruktorok
            public Allat()
            {
                this.Name = "Anonim";
                this.Hang = "Én egy állat vagyok";

            }
            public Allat(string name)
            {
                this.Name = name;
                this.Hang = "Én egy állat vagyok";

            }
            //Metódusok
            public void hangotAd()
            {
                Console.WriteLine("Ezt A hangotAd() metódus írta ki");
                Console.ReadKey();
            }
            //Virtual metódus
            public virtual void mozog()
            {
                Console.WriteLine("Azt a virtual metódus mozog() írta ki ");
            }
        }
        class kutya : Allat
        {
            public kutya() : base()
            {
                this.Hang = "Én egy kutya vagyok";
                Console.ReadKey();
            }
            public   void hangotAd()
            {
                Console.WriteLine("Ezt a hangotAd() funkció írta ki ");
                Console.ReadKey();
            }
            public override void mozog()
            {
                Console.WriteLine("Ezt a felülírt  mozog() metódus írta ki");
                Console.ReadKey();
            }
            

        }
        class Komondor : kutya
        {
            public Komondor() : base()
            {
                this.Name = "Komondor";
            }
            //Lezárt metódust nem írhatjuk felül
            //public override void mozog()
            //Consol.WriteLine("elindultan");
            
            public void mozog()
            {

            }
        }
        sealed class Macska : Allat
        {
            public Macska()
            {
                this.Name = "Cicamica";
            }
        }
        /*
         Lezárt osztályból nem származható
        Class Sziami:Macska{
        
        }*/

    }
}
