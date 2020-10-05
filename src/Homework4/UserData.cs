using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class UserData
    {
        public DateTime GetDateTime { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// UserAge
        /// </summary>
        public int UserAge { get; set; }

        public DateTime GetUserDateTimeNow()
        {
            GetDateTime = DateTime.Now;
            return GetDateTime;
        }

        public string GetName()
        {
            Console.Write("Please enter you name: ");
            UserName = Console.ReadLine();
            return UserName;
        }

        public int GetAge()
        {
            bool canParse = default;
            do
            {
                Console.Write("Please enter you age: ");
                canParse = int.TryParse(Console.ReadLine(), out int val1);
                UserAge = val1;
            }
            while (!canParse);

            return UserAge;
        }
    }
}
