using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObejctOOP
{

    public class animalTwo : Animal
    {
        public string area;
        public string color;

      
        public void printDetails()
        {
            Console.WriteLine("Name : " + name + "Age : " + age + "voice : " + voice + "Area : " + area + "Color" + color);
        }
        //Class
        //Constructor
        //string _name,int _age, string _voice, string _area, string _color
        public animalTwo(string _name, int _age, string _voice, string _area, string _color)
        {
            this.name = _name;
            this.age = _age;
            this.voice = _voice;
            this.area = _area;
            this.color = _color;

        }

    }
}
