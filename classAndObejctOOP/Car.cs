using System;

namespace classAndObejctOOP
{
     class Car
    {
        public int Hp { get; set; }
        public string Color { get; set; }


     
        public Car(int hp , string color)
        {
            this.Hp = hp;   
            this.Color = color; 
        }
        public void showDetails()
        {
            Console.WriteLine("Hp : " + Hp + "Color : " + Color);
        }
        public virtual  void repairDetails()
        {
            Console.WriteLine("The car is repaired");
        }
    }
}
