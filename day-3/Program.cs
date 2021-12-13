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
            Console.WriteLine($"Part one solution: {SolvePartOne(input)}");
            //Console.WriteLine($"Part two solution: {SolvePartTwo(input)}");
            Console.WriteLine("################################");
        }

        private static int SolvePartOne(string[] input)
        {
            string gammaBytes = "";
            string epsilonBytes = "";

            for (int i = 0; i < input[0].Length; i++)
            {
                int ones = 0;
                int zeros = 0;
                foreach (string line in input)
                {
                    //go through 1st char for each line, then 2nd, 3rd etc.
                    char temp = line.ToCharArray()[i];
                    if (temp.Equals('0'))
                    {
                        //should have 5 zeros
                        zeros++;
                    }
                    else
                    {
                        //should have 5 ones
                        ones++;
                    }
                }

                // add to gammaBytes - if ones > zeros then set value to 1, else 0
                gammaBytes += (ones > zeros) ? "1" : "0";
                // add to epsilonBytes - if ones > zeros then set value to 0, else 1
                epsilonBytes += (ones > zeros) ? "0" : "1";
            }

            //converts binaries into decimal
            int gammaInt = Convert.ToInt32(gammaBytes, 2);
            int epsilonInt = Convert.ToInt32(epsilonBytes, 2);

            //gamma * epsilon = power consumption
            return gammaInt * epsilonInt;
        }

        //private static int SolvePartTwo(string[] input)
        //{
        //}
    }
}

