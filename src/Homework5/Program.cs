using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfoAnimalZoll();
        }

        private static void GetInfoAnimalZoll()
        {
            var elephand = new Elephand();

            elephand.GetName();
            elephand.ElephandColor();
            elephand.ElLenght();

            Console.WriteLine(elephand.Brand);
            Console.WriteLine(elephand.Lenght);
            Console.WriteLine(elephand.Color);
            List<string> zoo = new List<string>() { elephand.Brand };

            foreach (var item in zoo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
