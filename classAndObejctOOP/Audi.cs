using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObejctOOP
{
    internal class Audi:Car
    {
        private string brand = "Audi";

        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Hp = hp;
            this.Model = model;
            this.Color = color;
        }

        public void showDetails()
        {
            Console.WriteLine("Hp : " + Hp + "Color : " + Color + "Model : " + Model);
        }

        public override void repairDetails()
        {
            Console.WriteLine(Model + "car is repaired");
        }
    }
}
