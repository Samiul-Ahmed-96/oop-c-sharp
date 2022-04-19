﻿using System;

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

            //Console.WriteLine(Pi);
            //Console.WriteLine(zidan.name);
            //Console.WriteLine(zidan.health);
            //Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
 