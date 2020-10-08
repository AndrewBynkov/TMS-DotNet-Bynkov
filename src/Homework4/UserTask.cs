using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Homework4
{
    public class UserTask
    {
        /// <summary>
        /// arrayOfTask
        /// </summary>
        private string[] _arrTask = new string[100];

        public (int lenghtArrList, string[] _arrTask) GetUserTask(DateTime userDateTime, TaskStatus taskSt)
        {
            int count = default;

            while (KeyOfContinue())
            {
                Console.Write("\n\nEnter you task: ");
                _arrTask[count] = (userDateTime + " - " + Console.ReadLine() + "\n" + "status: " + taskSt.GetTaskStatus());
                count++;
                userDateTime = DateTime.Now;
            }
            return (count, _arrTask);
        }

        public bool KeyOfContinue()
        {
            Console.Write("You want to continue? Y/y: ");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Y;
        }

        public void GetTaskInfo(int lenghtArrayOfTask, string [] arrayOfTask, UserData Data)
        {
            Console.WriteLine();
            for (int i = 0; i < lenghtArrayOfTask; i++)
            {
                Console.WriteLine($"Name - {Data.UserName}");
                Console.WriteLine($"Age - {Data.UserAge}");
                Console.WriteLine($"Task #{i+1} - {arrayOfTask[i]}\n");
            }
        }
    }
}
