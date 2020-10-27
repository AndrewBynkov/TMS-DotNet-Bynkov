using System;
using System.Reflection;

namespace Homework8
{
    class Program
    {
        public static event Func<double> DelegateRun;

        static void Main(string[] args)
        {
            userСhoice();
        }

        public static void userСhoice()
        {
            var walkingMode = new FitnessModeWalking(DateTime.Now);
            var runMode = new RunMode();

            Console.Write("Pease enter mode (Run/Walking): ");
            string userInput = Console.ReadLine();

            if (userInput == "Run")
            {
                DelegateRun += runMode.Run;
            }
            if (userInput == "Walking")
            {
                walkingMode.GetInfoWalking();
            }
        }
    }
}
