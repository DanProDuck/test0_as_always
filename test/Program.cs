using System;
using static System.Console;
using static System.Math;
using static System.Array;

namespace test
{
    class ConsoleApp2
    {
        static void Main(string[] args)
        {
            int n, m;
            String[] input = Console.ReadLine().Split();
            n = Convert.ToInt32(input[0]);
            m = Convert.ToInt32(input[1]);

            Console.WriteLine(n + " " + m);

            String[] mass = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(mass[i]);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }

            Console.WriteLine(mass);

            //int t = int.Parse(Console.ReadLine());

            //string[] input = Console.ReadLine().Split();
            /*for (int i = 0; i < t; i++)
            {
                int a = Convert.ToInt32(input[0]);
                if (b > a) Console.WriteLine(b - a);
                else if (a % b == 0) Console.WriteLine(0);
                else Console.WriteLine(b - (a % b));
            }*/




        }
    }
}
