using System;
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
                Console.Write("Select language dutch/english/russian: ");

                switch (_getUserLanguage = Console.ReadLine().ToLower().Replace(" ", ""))
                {
                    case nameof(EnumLanguage.dutch):
                        canParse = true;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        Massage.Invoke();
                        break;
                    case nameof(EnumLanguage.english):
                        canParse = true;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        Massage.Invoke();
                        break;
                    case nameof(EnumLanguage.russian):
                        canParse = true;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
                        Massage.Invoke();
                        break;
                }
            }
            Console.WriteLine();
            return _getUserLanguage;
        }

        public void MassageGoodMorning()
        {
            if (DateTime.Now.Hour < 12.00)
            {
                Console.WriteLine($"Good morning!");
            }
            else
            {
                Console.WriteLine("Good afternoon!");
            }
        }
    }
}
