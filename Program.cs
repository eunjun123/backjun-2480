﻿using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            if (a == b & b == c)
            {
                Console.WriteLine($"{10000 + a * 1000}");
                return;

            }
            if (a == b)
            {
                Console.WriteLine($"{1000 + a * 100}");
                return;
            }
            else if (b == c)
            {
                Console.WriteLine($"{1000 + b * 100}");
                return;
            }
            else if (c == a)
            {
                Console.WriteLine($"{1000 + c * 100}");
                return;

            }
            if (!(a == b) && !(b == c))
            {
                Array.Sort(s);
                Array.Reverse(s);
                Console.WriteLine($"{int.Parse(s[0]) * 100}");
                return;
            }
        }
    }