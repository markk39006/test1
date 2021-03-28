using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a; int y = b;
            while (x != y)
            {
                if (x < y == true)
                {
                    x = x + a;
                }
                else if (x < y == false)
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
