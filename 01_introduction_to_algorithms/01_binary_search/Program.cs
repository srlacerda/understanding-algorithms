﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var myList = new List<int> { 1, 3, 5, 7, 9 };
            //Console.WriteLine(BinarySearch(myList, 3)); // => 1
            //Console.WriteLine(BinarySearch(myList, -1)); // => null gets printed as an empty string

            var myList = new List<int> { 1, 3, 5, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}; //16 itens
            Console.WriteLine(BinarySearch(myList, 19)); // => 14
            Console.WriteLine(BinarySearch(myList, 3)); // => 1
            Console.WriteLine(BinarySearch(myList, 10)); // => 5
            Console.WriteLine(BinarySearch(myList, -1)); // => null gets printed as an empty string
        }

        private static int? BinarySearch(IList<int> list, int item)
        {
            var low = 0;
            var high = list.Count() - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = list[mid];
                if (guess == item) return mid;
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return null;
        }
    }
}