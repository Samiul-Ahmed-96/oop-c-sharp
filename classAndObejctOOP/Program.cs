using System;

namespace classAndObejctOOP
{
    internal class Program
    {
        //Enum
        public enum MailDetails
        {
            regularEmail = 2,
            regularAirMail = 5,
            expressMail = 12,
        }
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

            var expressMail = MailDetails.expressMail;

            Console.WriteLine(email);   
            Console.WriteLine(Pi);
            Console.WriteLine(zidan.name);
            Console.WriteLine(zidan.health);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
 