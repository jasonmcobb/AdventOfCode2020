﻿using System;

namespace AdventOfCode2020
{
    public class Day1
    {
        public static int[] inputSourceArray = new int[] {
            1973,
            1755,
            1601,
            1852,
            493,
            1905,
            1752,
            1946,
            1608,
            1438,
            1383,
            1281,
            1918,
            1125,
            1624,
            1802,
            1513,
            1574,
            1871,
            1831,
            1842,
            1869,
            1982,
            1027,
            1009,
            1020,
            1016,
            1336,
            1519,
            1721,
            1960,
            1889,
            1299,
            1355,
            1622,
            399,
            1919,
            1749,
            1709,
            1425,
            1789,
            1620,
            1071,
            1248,
            1786,
            1879,
            1208,
            1697,
            1643,
            1510,
            1578,
            1152,
            1592,
            1985,
            1653,
            1112,
            591,
            1784,
            1393,
            1607,
            1130,
            1054,
            1120,
            1619,
            1029,
            1453,
            1850,
            1451,
            1753,
            1483,
            1021,
            1553,
            1561,
            1656,
            1975,
            1600,
            1677,
            1912,
            1334,
            1526,
            1345,
            1115,
            2010,
            1758,
            1664,
            1102,
            1588,
            1339,
            1745,
            1605,
            1638,
            1599,
            1741,
            1147,
            1837,
            1142,
            1774,
            1562,
            1936,
            1810,
            1648,
            1576,
            1794,
            1621,
            1194,
            1246,
            1727,
            1915,
            1793,
            1037,
            1587,
            1103,
            1947,
            1116,
            1567,
            1528,
            1964,
            1163,
            1980,
            1672,
            1773,
            1593,
            1586,
            169,
            1613,
            1712,
            1854,
            1632,
            1760,
            1182,
            1812,
            1811,
            1660,
            1728,
            1067,
            1835,
            1501,
            1335,
            1647,
            1853,
            543,
            1108,
            1024,
            1559,
            1717,
            1826,
            1544,
            1585,
            1655,
            1386,
            1331,
            1485,
            1537,
            1290,
            1941,
            1734,
            2003,
            1151,
            1679,
            1782,
            1783,
            1146,
            1277,
            1766,
            1900,
            530,
            1955,
            1268,
            1968,
            1432,
            1170,
            1867,
            1005,
            1202,
            1564,
            1096,
            1707,
            1309,
            1094,
            1295,
            1974,
            1404,
            1229,
            1883,
            1838,
            1997,
            1536,
            408,
            1149,
            1945,
            1454,
            1856,
            1792,
            1614,
            1492,
            1823,
            1803,
            1533,
            1726,
            1364,
            };
        public int[] DayOne()
        {
            Console.WriteLine("You Selected Day One");
            int[] Results = new int[2];
            Results[0] = dayOnePartOne();
            Results[1] = dayOnePartTwo();
            return Results;
        }

        public int dayOnePartOne()
        {
            Console.WriteLine("Processing Day One Part One");
            foreach (var inputOne in inputSourceArray)
            {
                foreach (var inputTwo in inputSourceArray)
                {
                    if (inputOne != inputTwo)
                    {
                        if (inputOne + inputTwo == 2020)
                        {
                            return (inputOne * inputTwo);
                        }
                    }
                }
            }
            return 0;
        }

        public int dayOnePartTwo()
        {
            Console.WriteLine("Processing Day One Part Two");
            foreach (var inputOne in inputSourceArray)
            {
                foreach (var inputTwo in inputSourceArray)
                {
                    foreach (var inputThree in inputSourceArray)
                    {
                        if (inputOne != inputTwo && inputOne != inputThree && inputTwo != inputThree)
                        {
                            if (inputOne + inputTwo + inputThree == 2020)
                            {
                                return (inputOne * inputTwo * inputThree);
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
