using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tLIST OF YOUR TASKS V1.2\n\n");

            UserData userData = new UserData();
            UserTask userTask = new UserTask();

            userData.GetName();
            userData.GetAge();
            userData.GetUserDateTimeNow();
            (var lenghtArrayOfTask, string [] listOfTask) = userTask.GetUserTask(userData.GetDateTime);

            Console.WriteLine($"\n\nHi {userData.UserName}! You have {userData.UserAge} years old - you yang! Here is your to-do list for the day: ");
            userTask.GetTaskInfo(lenghtArrayOfTask, listOfTask);
        }
    }
}
