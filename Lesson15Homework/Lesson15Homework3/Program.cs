using System;

namespace Lesson15Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train1 = new Train();
            Train train2 = new Train();
            Train train3 = new Train();
            Train train4 = new Train();
            Train train5 = new Train();
            Train train6 = new Train();
            Train train7 = new Train();
            Train train8 = new Train();
            Train[] trains = new Train[] { train1, train2, train3, train4, train5, train6, train7, train8 };

            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].NumberPrint();
            }
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].DeparturesPrint();
            }
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].TimePrint();
            }
        }
    }
}

