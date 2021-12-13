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

            Console.WriteLine("########## Day 3 2021 ##########");
            //Console.WriteLine($"Part one solution: {SolvePartOne(input)}");
            Console.WriteLine($"Part two solution: {SolvePartTwo(input)}");
            Console.WriteLine("################################");
        }

        private static int SolvePartOne(string[] input)
        {
        //for each binary number
            //GAMMA: get most common number from each of the 5 bits and from that create new binary, then covert to demical

            //EPSILON: same as above but for least commmon

            //GAMMA * EPSILON = power consumptions;
        }

        private static int SolvePartTwo(string[] input)
        {
        }
    }
}