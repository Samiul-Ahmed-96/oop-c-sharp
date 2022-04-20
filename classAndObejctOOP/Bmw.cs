using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObejctOOP
{
    sealed class Bmw : Car
    {
        private string brand = "Bmw";

        public string Model { get; set; }

        public Bmw(int hp , string color , string model):base(hp, color)
        {
            this.Hp = hp;
            this.Model = model;
            this.Color = color;
        }

        public void showDetails()
        {
            Console.WriteLine("Hp : " + Hp + "Color : " + Color + "Model : " + Model);
        }

        public sealed override void repairDetails()
        {
            Console.WriteLine(Model+ "car is repaired");
        }
    }
}
