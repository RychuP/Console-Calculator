﻿using System;

namespace Calculator
{
    class Program
    {
        public static readonly string Title = $"Console Calculator v0.65";
        static void Main(string[] args)
        {
            Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 90;
            Console.Title = Title;
            Input input = new Input();

            while (!input.Exit)
            {
                input.Print();
            }
        }
    }
}
