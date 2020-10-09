using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfoAnimalZoo();
        }

        private static void GetInfoAnimalZoo()
        {
            var elephand = new Elephand();
            elephand.GetName();
            elephand.ElephandColor();
            elephand.ElLenght();
            string[] elephndArray = new string[]
            {
                $"Name elephand - {elephand.Brand}" +
                $"\nColor elephand - {elephand.Color}" +
                $"\nLenght elephand - {elephand.Lenght}m"
            };
            Console.WriteLine();

            var zebra = new Zebra();
            zebra.GetNameZebra();
            zebra.ZebraColor();
            zebra.Height();
            zebra.Weigh();
            string[] zebraArray = new string[]
            {
                $"Name zebra - {zebra.Brand}" +
                $"\nColor zebra - {zebra.Color}" +
                $"\nHeight zebra - {zebra.HeightZebra}m" +
                $"\nWeight zebra - {zebra.Weight}kg"
            };
            Console.WriteLine();

            List<string[]> zoo = new List<string[]>
            {
                elephndArray,
                zebraArray
            };

            Console.WriteLine("List of animal from the my zoo:");
            foreach (var item in zoo)
            {
                Console.WriteLine("==========");
                Console.WriteLine(item[0]);
                Console.WriteLine("==========");
            }
        }
    }
}
