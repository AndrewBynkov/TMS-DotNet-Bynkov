using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tLIST OF YOUR TASKS V1.2\n\n");
            DateDayWeek dateDayWeek = new DateDayWeek();
            UserTask userTask = new UserTask();

            DateTime DateDay = dateDayWeek.inpDate;
            userTask.inpUserTask(DateDay);
        }
    }
}
