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
            var walkingMode = new FitnessModeWalking(DateTime.Now);
            var runMode = new FitnessModeRun(DateTime.Now);

            WalkingInfo = walkingMode.GetInfoWalking;

            string userInputNameMode = null;

            while (userInputNameMode!= "Run" || userInputNameMode!= "Walking")
            {
                Console.Write("Pease enter mode (Run/Walking): ");
                userInputNameMode = Console.ReadLine();
            }

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
