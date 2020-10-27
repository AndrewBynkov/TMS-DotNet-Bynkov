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
            Console.Write("Enter walking time: ");
            var timeWalking = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter run time: ");
            var timeRun = Convert.ToInt32(Console.ReadLine());

            var walkingMode = new FitnessModeWalking(timeWalking);
            var runMode = new FitnessModeRun(timeRun);

            WalkingInfo = walkingMode.GetInfoWalking;

            string userInputNameMode;
            bool canParse = false;

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

            }
            if (userInputNameMode == "Walking")
            {
                WalkingInfo();
            }
        }
    }
}
