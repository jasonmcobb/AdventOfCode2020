using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day2
    {
        public string[] fileContents;
        // public int counter = 0;

        public Day2(string filePath)
        {
            fileContents = File.ReadAllLines(filePath);
        }

        public int dayTwoPartOne()
        {
            char[] trimChar = { ':' };
            int counter = 0;
            foreach (string Line in fileContents)
            {
                var TempHolder = Line.Split(" ");
                Int32.TryParse(TempHolder[0].Split("-")[0], out int lowerBound);
                Int32.TryParse(TempHolder[0].Split("-")[1], out int upperBound);
                char[] charToCheck = TempHolder[1].Trim(trimChar).ToCharArray();
                int charCounter = TempHolder[2].ToCharArray().Count(c => c == charToCheck[0]);
                if ((lowerBound <= charCounter) && (charCounter <= upperBound))
                {
                    counter++;
                }
            }
            return counter;
        }

        public int dayTwoPartTwo()
        {
            int counter = 0;
            char[] trimChar = { ':' };
            foreach (string Line in fileContents)
            {
                var TempHolder = Line.Split(" ");
                Int32.TryParse(TempHolder[0].Split("-")[0], out int lowerBound);
                Int32.TryParse(TempHolder[0].Split("-")[1], out int upperBound);
                string charToCheck = TempHolder[1].Trim(trimChar);
                int lowerBoundCheck = TempHolder[2].IndexOf(charToCheck, (lowerBound - 1));
                int upperBoundCheck = TempHolder[2].IndexOf(charToCheck, (upperBound - 1));
                // This is a ridiculous if statement, but it works.
                if (((lowerBound - 1 == lowerBoundCheck) && (upperBoundCheck != upperBound - 1)) || ((lowerBoundCheck != lowerBound - 1) && (upperBound - 1 == upperBoundCheck)))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
