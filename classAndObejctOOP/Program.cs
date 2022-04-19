using System;

namespace classAndObejctOOP

{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP _ Class and Object");



            Player zidan = new Player();
            zidan.name = "zidan";
            zidan.health = 34;
            zidan.isBrazillian = false;


            Player messi = new Player();
            messi.name = "Messi";
            messi.health = 100;
            messi.isBrazillian = false;

            int a = 10;
            int b = 20;
            int result;

            NumberCompare n = new NumberCompare();

            result = n.FindMax(a, b);


            const float Pi = 3.1416f;
            //Array of objects
            string[] names = {"Sakib", "Abir","Hasib"};

            for (int i = 0; i < names.Length; i++) { 
                Console.WriteLine(names[i]);
            }

            var season = Season.Winter;

            switch (season)
            {
                case Season.Summer:
                    Console.WriteLine("this is summer");
                    break;
                case Season.Rainy:
                    Console.WriteLine("this is Rainy");
                    break;
                case Season.Winter:
                    Console.WriteLine("this is Winter");
                    break;

                    default:
                    Console.WriteLine("There is no season");
                    break;
            }

            //Class
            //Constructor
            Animal tiger = new Animal("Tiger", 4, "WWWWWWW");
            tiger.printDetails();


            //Inhertance object
            animalTwo hilsha = new animalTwo("Hilsha", 3,"Ddd" , "Padma","gray");
            hilsha.printDetails();

            //Getter Setter
            
            Income moneyleft = new Income();
            moneyleft.debit(2000);

            moneyleft.debit(5000);



            //moneyleft.income = moneyleft.income - 430000;
            //moneyleft.income = 10000;

            moneyleft.income = 6000;

            Console.WriteLine(moneyleft.income);

            
        //Console.WriteLine(Pi);
        //Console.WriteLine(zidan.name);
        //Console.WriteLine(zidan.health);
        //Console.WriteLine(result);
        Console.ReadLine();
        }
    }
}
 