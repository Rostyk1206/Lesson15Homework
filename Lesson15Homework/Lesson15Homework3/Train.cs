using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15Homework3
{
    struct Train
    {
        public string departures;
        public int number;
        public string time;

        public void DeparturesPrint()
        {
            Console.WriteLine($"Departures of  train");
            string departures = Console.ReadLine();
        }
        public void NumberPrint()
        {
            Console.WriteLine($"Number of train");
            number = int.Parse(Console.ReadLine());
        }
        public void TimePrint()
        {
            Console.WriteLine($"Time of train");
            string time = Console.ReadLine();
        }
    }
}
