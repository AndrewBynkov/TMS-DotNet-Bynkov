using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Transactions;

namespace Homework5
{
    public class Elephant : AbstractAnimals, Ielephant
    {
        public string GetName()
        {
            Console.Write($"Enter name {nameof(Elephant)}: ");
            Brand = Console.ReadLine();
            return Brand;
        }

        public string ElephandColor(string Elcolor)
        {
            Console.Write($"Enter color {nameof(Elephant)}: ");
            Color = Console.ReadLine();
            return Color;
        }

        public void ElLenght()
        {
            var canParse = false;
            do
            {
                Console.Write($"Enter lenght {nameof(Elephant)}: ");
                canParse = double.TryParse(Console.ReadLine(), out double val1);
                Lenght = val1;
            }
            while (!canParse);
        }
    }
}
