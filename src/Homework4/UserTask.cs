using System;

namespace Homework4
{
    class UserTask
    {
        public void inpUserTask(DateTime dateImpDay)
        {
            string[] taskArray = new string[100];
            string Next = "yes";
            string Task = default;
            int count = 0;

            while (Next == "yes" || Next == default)
            {
                Console.Write($"\n{dateImpDay} - {dateImpDay.DayOfWeek}\t");
                Console.Write("Enter you task: ");
                Task = Console.ReadLine().ToLower();

                taskArray[count] = Task;
                count++;

                Console.Write("Continue? yes/no: ");
                Next = Console.ReadLine().ToLower().Replace(" ", "");
            }
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Task #{i + 1} of the day {dateImpDay} - {dateImpDay.DayOfWeek}: {taskArray[i]}");
            }
        }
    }
}

