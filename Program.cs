using Demo;
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            Console.WriteLine("Length of the string is" + " "+str1.Length);

            Demo1 d = new Demo1();
            d.message();
            Console.ReadLine();
        }
    }
}
