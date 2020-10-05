using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class TaskStatus
    {
        public string GetTaskStatus()
        {
            string userStatus = null;
            var getStatus = false;

            while(!getStatus)
            {
                Console.Write("Enter status you task (Start, Inprogress, Finish): ");
                userStatus = Console.ReadLine().ToLower().Replace(" ", "");

                switch (userStatus)
                {
                    case "start":
                        getStatus = true;
                        break;
                    case "finish":
                        getStatus = true;
                        break;
                    case "inprogress":
                        getStatus = true;
                        break;
                }
            }
            return userStatus;
        }
    }
}
