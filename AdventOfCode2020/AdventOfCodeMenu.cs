using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day objects:
            Day1 dayOneObject = new Day1();
            Day2 dayTwoObject = new Day2("/Users/jasoncobb/Projects/AdventOfCode2020/AdventOfCode2020/Inputs/Day2.txt");

            Console.WriteLine("Which day would you like to run(1-2)?");
            var inputChoice = Console.ReadLine();
            switch (inputChoice)
            {
                case "1":
                    int[] dayOne = dayOneObject.DayOne();
                    Console.WriteLine($"Output for Day One Part One is {dayOne[0]}");
                    Console.WriteLine($"Output for Day One Part Two is {dayOne[1]}");
                    break;
                case "2":
                    var dayTwoPartOneResponse = dayTwoObject.dayTwoPartOne();
                    var dayTwoPartTwoResponse = dayTwoObject.dayTwoPartTwo();
                    Console.WriteLine($"Output for Day Two Part One is {dayTwoPartOneResponse}");
                    Console.WriteLine($"Output for Day Two Part Two is {dayTwoPartTwoResponse}");
                    break;
                default:
                    Console.WriteLine("You either entered an invalid number or a day that hasn't happened yet.");
                    break;
            }
        }
    }
}
