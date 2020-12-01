using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which day would you like to run(1)?");
            var inputChoice = Console.ReadLine();
            Day1 dayOneObject = new Day1();
            switch (inputChoice)
            {
                case "1":
                    int[] dayOne = dayOneObject.DayOne();
                    Console.WriteLine($"Output for Day One Part One is {dayOne[0]}");
                    Console.WriteLine($"Output for Day One Part Two is {dayOne[1]}");
                    break;
                default:
                    Console.WriteLine("You either entered an invalid number or a day that hasn't happened yet.");
                    break;
            }
        }
    }
}
