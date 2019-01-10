using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString c1 = new MyString("Hello");
            MyString c2 = new MyString("World");

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.ReadKey();
        }
    }
}
