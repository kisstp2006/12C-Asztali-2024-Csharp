using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Person
    {
        public Person() { }

        public string Name { get; set; }
        private int id;
        public int ID { get => id; set=> id=101 ; }

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
                case "Férfi" :
                    this.gender = 1;
                    break;
                case "Nő":
                    this.gender = 2;
                    break;
                default:
                    this.gender = 0;
                    break;
            }
        }
    }
}
