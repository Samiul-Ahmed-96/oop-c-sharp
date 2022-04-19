using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObejctOOP
{
    internal class Animal
    {
        public string name;
        public int age;
        public string voice;

        public void printDetails()
        {
            Console.WriteLine("Name : " + name + "Age : " + age + "voice : " + voice );
        }
        //Class
        //Constructor
        public Animal(string _name , int _age, string _voice)
        {
            name = _name;
            age = _age;
            voice = _voice;

        }
    }

}
