using System;
using System.IO;
using System.Linq;

namespace day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzleInput.txt"));
            int[] report = Array.ConvertAll(input, s => Int32.Parse(s));

            Console.WriteLine("########## Day 2 2021 ##########");
            //Console.WriteLine($"Part one solution: {SolvePartOne(report)}");
            //Console.WriteLine($"Part two solution: {SolvePartTwo(report)}");
            Console.WriteLine("################################");
        }
    }
}