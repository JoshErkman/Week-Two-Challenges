using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    public class Greeter
    {
        public void UI()
        {
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();
            
            string replyOne = "Hello " + userInput + "! It's a beautiful day eh?";
            Console.WriteLine(replyOne);

            string replyTwo = "Goodbye " + userInput + "! It was good hearing from you.";
            Console.WriteLine(replyTwo);

            TimeSpan time = DateTime.Now.TimeOfDay;

            if (time > new TimeSpan(3, 00, 00) && time < new TimeSpan(12, 00, 00))
            {
                string morningReply = "Good morning " + userInput + ".";
                Console.WriteLine(morningReply);

            }
            else if (time >= new TimeSpan(12, 00, 00) && time < new TimeSpan(16, 00, 00))
            {
                string afternoonReply = "Good afternoon " + userInput + ".";
                Console.WriteLine(afternoonReply);

            }
            else if (time >= new TimeSpan(16, 00, 00) && time < new TimeSpan(20, 00, 00))
            {
                string eveningReply = "Good evening " + userInput + ".";
                Console.WriteLine(eveningReply);

            }
            else
            {
                string nightReply = "Good night " + userInput + ".";
                Console.WriteLine(nightReply);

            }

            Console.ReadKey();

        }

    }
}

