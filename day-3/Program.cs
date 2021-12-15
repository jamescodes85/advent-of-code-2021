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
            Console.WriteLine($"Part two solution: {SolvePartTwo(input)}");
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
                    //iterate over bit positions, starting with 1st line, 1st bit, 2nd line, 1st bit etc.
                    char temp = line.ToCharArray()[i];
                    switch (temp)
                    {
                        case '0':
                            zeros++;
                            break;
                        case '1':
                            ones++;
                            break;
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

        private static int SolvePartTwo(string[] input)
        {
            //get 1st bit of each list item and keep only numbers selected by BIT CRITERIA; bin the rest
            //if you only have one number left, stop and take number as the answer
            //then iterate over the 2nd/3rd/4th bit etc. as per above
            for (int i = 0; i < input[0].Length; i++)
            {
                int ones = 0;
                int zeros = 0;
                foreach (string line in input)
                {
                    //iterate over bit positions, starting with 1st line, 1st bit, 2nd line, 1st bit etc.
                    char temp = line.ToCharArray()[i];
                    switch (temp)
                    {
                        case '0':
                            zeros++;
                            break;
                        case '1':
                            ones++;
                            break;
                    }
                }
                if (zeros > ones)
                {
                    //remove all lines starting with 1
                }
                else
                {
                    //remove all lines starting with 0
                }
            }
            //var oxygenGeneratorRating = most common value in current bit position, keeping only numbers with that bit in that position. If 0/1 are equally common, keep 1
            return 1;

            //BIT CRITERIA (step-by-step examples: https://adventofcode.com/2021/day/3)
            
            //co2GeneratorRating = as above but least common and if 0/1, keep 0

            //lifeSupportRating = oxygenGeneratorRating (as decimal) * co2ScrubberRating (as decimal)
        }
    }
}

