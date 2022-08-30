using System;

namespace ConsoleApp1
{
    class Test
    {
        int x;
        public Test(int x)
        {
            this.x = x;
            Console.WriteLine(x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(5);
        }
    }
}
