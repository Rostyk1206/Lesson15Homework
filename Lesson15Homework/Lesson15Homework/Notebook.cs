using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15Homework
{
    struct Notebook
    {
        public string model;
        public string maker;
        public int price;

        public Notebook(string model,string maker,int price)
        {
            this.model = model;
            this.maker = maker;
            this.price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Model:{model}, Maker:{maker}, Price:{price}");
        }
    }
}
