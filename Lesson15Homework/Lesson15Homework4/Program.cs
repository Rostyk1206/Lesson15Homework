using System;

namespace Lesson15Homework4
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "CHANGE_Class";
            Console.WriteLine($"{myClass.change}");
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Change_Struct";
            Console.WriteLine($"{myStruct.change}");
        }
        static void Main(string[] args)
        {

            MyClass myclass1 = new MyClass();
            MyStruct mystruct1 = new MyStruct();
            myclass1.change = "Not change class";
            mystruct1.change = "Not change struct";
            Console.WriteLine($"{myclass1.change}");
            Console.WriteLine($"{mystruct1.change}");



        }

    }
}
