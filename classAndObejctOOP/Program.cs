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


            Console.WriteLine(zidan.name);
            Console.WriteLine(zidan.health);
        }
    }
}
