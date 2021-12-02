using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input2.txt");

            var depth = 0;
            var horizontal = 0;
            var aim = 0;
            foreach (var line in lines)
            {
                var splitLine = line.Split(" ");
                var command = splitLine[0];
                var number = int.Parse(splitLine[1]);

                switch (command)
                {
                    case "up":
                        aim -= number;
                        break;
                    case "down":
                        aim += number;
                        break;
                    case "forward":
                        horizontal += number;
                        depth += number * aim;
                        break;
                }
            }

            var final = depth * horizontal;
            Console.WriteLine(final);
        }

        private static void Day1()
        {
            Part1();

            var lines = File.ReadAllLines("input.txt").Select(int.Parse).ToArray();
        }

        private static void Part1()
        {
            var lines = File.ReadAllLines("input.txt").Select(int.Parse).ToArray();
            var currentMeasurement = lines[0] + lines[1] + lines[2];

            var count = 0;
            for (int i = 1; i < lines.Length - 2; i++)
            {
                var measurement = lines[i] +
                                  lines[i + 1] +
                                  lines[i + 2];
                if (measurement > currentMeasurement)
                    count++;

                currentMeasurement = measurement;
            }

            //int count = 0;
            //foreach (var line in lines)
            //{
            //    var measurement = line;
            //    if (measurement > currentMeasurement)
            //        count++;

            //    currentMeasurement = measurement;
            //}

            Console.WriteLine(count);
        }
    }
}
