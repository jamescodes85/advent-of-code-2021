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

            Console.WriteLine("########## Day 2 2021 ##########");
            Console.WriteLine($"Part one solution: {SolvePartOne(input)}");
            Console.WriteLine($"Part two solution: {SolvePartTwo(input)}");
            Console.WriteLine("################################");
        }

        private static int SolvePartOne(string[] input)
        {
            int distanceCounter = 0;
            int depthCounter = 0;

            foreach (string s in input)
            {
                if (s.StartsWith("forward"))
                {
                    var inputNumber = GetNumber(s);
                    distanceCounter += inputNumber;
                }

                else if (s.StartsWith("down"))
                {
                    var inputNumber = GetNumber(s);
                    depthCounter += inputNumber;
                }

                else
                {
                    var inputNumber = GetNumber(s);
                    depthCounter -= inputNumber;
                }
            }
            int answer = distanceCounter * depthCounter;
            return answer;
        }

        private static int SolvePartTwo(string[] input)
        {
            int distanceCounter = 0;
            int depthCounter = 0;
            int aimCounter = 0;

            foreach (string s in input)
            {
                if (s.StartsWith("forward"))
                {
                    var inputNumber = GetNumber(s);
                    distanceCounter += inputNumber;
                    depthCounter += (aimCounter * inputNumber);
                }

                else if (s.StartsWith("down"))
                {
                    var inputNumber = GetNumber(s);
                    aimCounter += inputNumber;
                }

                else
                {
                    var inputNumber = GetNumber(s);
                    aimCounter -= inputNumber;
                }
            }
            int answer = distanceCounter * depthCounter;
            return answer;
        }

        private static int GetNumber(string input)
        {
            var trimString = new String(input.Where(Char.IsDigit).ToArray());
            var numberOnly = Int32.Parse(trimString);
            return numberOnly;
        }
    }
}