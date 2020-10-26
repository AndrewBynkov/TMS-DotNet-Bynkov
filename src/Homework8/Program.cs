using System;

namespace Homework8
{
    class Program
    {
        public static event Func<double> DelegateRun;

        public static event Func<double> DelegateWalking;

        static void Main(string[] args)
        {
            userChooese();
        }

        public static void userChooese()
        {
            var walkingMode = new FitnessMode(DateTime.Now);
            var runMode = new RunMode();

            Console.WriteLine("Pease enter mode (Run/Walking): ");
            string userInput = Console.ReadLine();

            if (userInput == "Run")
            {
                DelegateRun += runMode.Run;
            }
            if (userInput == "Walking")
            {
                DelegateWalking += walkingMode.Walking;
            }
        }
    }
}
