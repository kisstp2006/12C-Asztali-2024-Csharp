using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Person
    {
        /*Az a project a property-k használatát mutatja be*/
        /*A property-k olyan változók amelyek publikusak és van két metódusuk
         - set az érték nek az ellenőrzött beállításához
         - get metódus az értékének az ellenörzött visszaadáshoz
            Tulajdonképpen az osztályváltozok (amelyek private láthattóságúak és külön külön írtuk hozzá beállító és kiolvasó metódusokat)
        eszerüsített kezelését teszi lehetővé
         */
        public Person() { }

        public string Name { get; set; }
        private int id;
        public int ID { get => id; set => id = 101; }

        private int age;

        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge() { return this.age; }
        private int gender;
        public void SetGender(string gender)
        {
            switch (gender)
            {
                case "Férfi":
                    this.gender = 1;
                    break;
                case "Nő":
                    this.gender = 2;
                    break;
                default:
                    this.gender = 3;
                    break;
            }
        }
        public string GetGender()
        {
            switch (this.gender)
            {
                case 1:
                    return "Férfi";
                    break;
                case 2:
                    return "Nő";
                    break;
                default: return "Nem helyes nem";
            }
        }
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ádám";
            Console.WriteLine(person.Name);

            person.ID = 99;
            Console.WriteLine(person.ID);
            Console.Read();
        }
    }
}
