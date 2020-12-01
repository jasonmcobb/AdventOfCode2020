using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which day would you like to run(1-31)?");
            var inputChoice = Console.ReadLine();
            Day1 dayOneObject = new Day1();
            switch (inputChoice)
            {
                case "1":
                    int dayOne = dayOneObject.DayOne();
                    Console.WriteLine($"Output for Day One is {dayOne}");
                    break;
                default:
                    break;
            }
        }
    }
}
