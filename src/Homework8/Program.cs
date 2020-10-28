using System;
using System.Reflection;

namespace Homework8
{
    class Program
    {
        public static Action RunInfo;
        public static Action WalkingInfo;

        static void Main(string[] args)
        {
            UserСhoice();
        }

        public static void UserСhoice()
        {
            int fitnessTime;
            bool canParse = false;

            do
            {
                Console.Write("Enter fitness time: ");
                canParse = int.TryParse(Console.ReadLine(), out int val1);
                fitnessTime = val1;
            }
            while (!canParse);


            var walkingMode = new FitnessModeWalking(fitnessTime);
            var runMode = new FitnessModeRun(fitnessTime);

            WalkingInfo = walkingMode.GetInfoWalking;
            RunInfo = runMode.GetInfo;

            string userInputNameMode;

            do
            {
                Console.Write("Enter name mode: Run/Walking: ");
                userInputNameMode = Console.ReadLine();

                if (userInputNameMode.Contains("Run") || userInputNameMode.Contains("Walking"))
                {
                    canParse = true;
                }
            }
            while (!canParse);

            if (userInputNameMode == "Run")
            {
                RunInfo();
            }
            if (userInputNameMode == "Walking")
            {
                WalkingInfo();
            }
        }
    }
}
