using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Transactions;

namespace Homework5
{
    public class Elephand : AbstractAnimals, Ielephand
    {

        public string GetName()
        {
            Console.Write($"Enter name {nameof(Elephand)}: ");
            Brand = Console.ReadLine();
            return Brand;
        }

        public string ElephandColor()
        {
            Console.Write($"Enter color {nameof(Elephand)}: ");
            Color = Console.ReadLine();
            return Color;
        }

        public void ElLenght()
        {
            var canParse = false;
            do
            {
                Console.Write($"Enter lenght {nameof(Elephand)}: ");
                canParse = double.TryParse(Console.ReadLine(), out double val1);
                Lenght = val1;
            }
            while (!canParse);
        }

    }
}
