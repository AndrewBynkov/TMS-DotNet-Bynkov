using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Transactions;

namespace Homework5
{
    public class Elephand : Animals, Ielephand
    {
        private string _name = null;

        public string GetName()
        {
            Console.Write("Enter brand animal: ");
            Brand = Console.ReadLine();
            return Brand;
        }

        public string ElephandColor()
        {
            Console.Write("Enter Color elephapd: ");
            Color = Console.ReadLine();
            return Color;
        }

        public void ElLenght()
        {
            Console.Write("Enter Lenght elephapd: ");
            Lenght = Convert.ToDouble(Console.ReadLine());
        }
    }
}
