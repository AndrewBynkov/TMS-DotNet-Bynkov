using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Homework6
{
    class Language : ILanguage
    {
        public delegate void ShowMassage();
        public event ShowMassage Massage;

        private string _getUserLanguage;

        public string GetUserLanguage()
        {
            var canParse = false;

            while (!canParse)
            {
                Console.Write("Select language: ");

                switch (_getUserLanguage = Console.ReadLine())
                {
                    case nameof(EnumLanguage.Dutch):
                        canParse = true;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        Massage.Invoke();
                        break;
                    case nameof(EnumLanguage.English):
                        canParse = true;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        Massage.Invoke();
                        break;
                    case nameof(EnumLanguage.Russian):
                        canParse = true;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
                        Massage.Invoke();
                        break;
                }
            }
            return _getUserLanguage;
        }

        public void MassageGoodMorning()
        {
            if (DateTime.Now.Hour < 12.00)
            {
                Console.WriteLine("Good morning!");
            }
            else
            {
                Console.WriteLine("Good afternoon!");
            }
        }
    }
}
