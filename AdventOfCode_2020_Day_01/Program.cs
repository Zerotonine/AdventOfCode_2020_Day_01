using System;
using System.Collections.Generic;
using System.IO;

/*
 * Solution for the 1st advent of code challenge 2020
 * Find out more about advent of code @ https://adventofcode.com/
 * */

namespace AdventOfCode_2020_Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>();
            const int NUMBER_TO_FIND = 2020 ;
            
            try
            {
                string[] input = File.ReadAllLines("input.txt");
                foreach(string s in input)
                {
                    if (Int32.TryParse(s, out int i))
                        inputList.Add(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }

            Console.WriteLine("Solution Puzzle One: " + PuzzleOne(inputList, NUMBER_TO_FIND));
            Console.WriteLine("Solution Puzzle Two: " + PuzzleTwo(inputList, NUMBER_TO_FIND));
            Console.ReadKey(true);
        }

        static int PuzzleOne(in List<int> l, in int target)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 1; j < l.Count; j++)
                {
                    if (l[i] + l[j] == target)
                    {
                        return l[i] * l[j];
                    }
                }
            }
            throw new Exception("Solution not found");
        }

        static int PuzzleTwo(in List<int> l, in int target)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 1; j < l.Count; j++)
                {
                    for(int k = 2; k < l.Count; k++)
                    {
                        if (l[i] + l[j] + l[k] == target)
                        {
                            return l[i] * l[j] * l[k];
                        }
                    }
                    
                }
            }
            throw new Exception("Solution not found");
        }
    }
}
