using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EurofinsCodingTask.Models
{
    public class UserInput
    {
        public int Id { get; set; }
        public int Start { get; set; } = 1; //Starting number from user, defaulted to 1
        public int End { get; set; } = 100; //Ending number from user, defaulted to 100

        public DateTime Date { get; set; } = DateTime.Now;

        public string Message()
        {
            // Method to generate required string
            string message = " ";
            for (int i = Start; i < End + 1; i++)
            {
                if (i % 15 == 0)
                {
                    message += " Eurofins ,";
                }
                else if (i % 3 == 0)
                {
                    message += " Three ,";
                }
                else if (i % 5 == 0)
                {
                    message += " Five ,";
                }
                else
                {
                    message += " " + i.ToString() + " ,";
                }
            }
            message = message.Substring(0, message.Length - 2); // To remove the final trailing space and comma. 
            return message;
        }
    }
}