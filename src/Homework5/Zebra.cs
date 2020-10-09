using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Zebra : AbstractAnimals, Izebra
    {
        public double HeightZebra { get; private set; }

        public string GetNameZebra()
        {
            Console.Write($"Enter name {nameof(Zebra)}: ");
            Brand = Console.ReadLine();
            return Brand;
        }
        public string ZebraColor()
        {
            Console.Write($"Enter color {nameof(Zebra)}: ");
            Color = Console.ReadLine();
            return Color;
        }
        public double Height(double heightZebra)
        {
            var canParse = false;
            do
            {
                Console.Write($"Enter haight {nameof(Zebra)}: ");
                canParse = double.TryParse(Console.ReadLine(), out double val1);
                HeightZebra = val1;
            }
            while (!canParse);

            return HeightZebra;
        }

        public void WeightZebra()
        {
            var canParse = false;
            do
            {
                Console.Write($"Enter weight {nameof(Zebra)}: ");
                canParse = double.TryParse(Console.ReadLine(), out double val1);
                Weight = val1;
            }
            while (!canParse);
        }
    }
}
