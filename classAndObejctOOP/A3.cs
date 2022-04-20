using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObejctOOP
{
    internal class A3:Bmw
    {
        public A3(int hp , string model , string color) : base(hp , model , color)
        {

        }
        public override void repairDetails()
        {
            Console.WriteLine(Model + "car is repaired");
        }
    }
}
