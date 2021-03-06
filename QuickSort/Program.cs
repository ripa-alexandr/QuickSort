﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[]
            {
                3, 4, 50, 100, 200, 0, 10, 20, 30, 500, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6,
                0, 2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 400, 10, 302, 10, 0, 1, 20,
                3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 4,
                50, 100, 200, 0, 10, 20, 30, 500, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0,
                2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 400, 10, 302, 10, 0, 1, 20, 3,
                5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23,
                778, 0, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10,
                5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 67, 8, 34, 8, 3, 4, 5, 2, 3, 7, 845, 3, 67, 8, 34, 8, 3,
                4, 5, 2, 3, 7, 867, 8, 34, 8, 3, 4, 5, 2, 3, 7, 8, 20, 304, 10, 2, 30, 4, 05, 660, 234, 102, 5053, 23,
                778, 0, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10,
                5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 67, 8, 34, 8, 3, 4, 5, 2, 3, 7, 845, 3, 67, 8, 34, 8, 3,
                4, 5, 2, 3, 7, 867, 8, 34, 8, 3, 4, 5, 2, 3, 7, 8, 20, 304, 10, 2, 30, 4, 05, 660, 234, 102, 50, 50, 100,
                200, 0, 10, 20, 30, 500, 4, 50, 100, 200, 0, 10, 20, 30, 5004, 50, 100, 200, 0, 10, 20, 30, 500, 7, 2, 3,
                4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 0, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456,
                3, 56, 100, 200, 0, 10, 20, 30, 500, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6,
                0, 2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 400, 10, 302, 10, 0, 1, 20,
                3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 4,
                50, 100, 200, 0, 10, 20, 30, 500, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0,
                2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 400, 10, 302, 10, 0, 1, 20, 3,
                5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23,
                778, 0, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10,
                5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 67, 8, 34, 8, 3, 4, 5, 2, 3, 7, 845, 3, 67, 8, 34, 8, 3,
                4, 5, 2, 3, 7, 867, 8, 34, 8, 3, 4, 5, 2, 3, 7, 8, 20, 304, 10, 2, 30, 4, 05, 660, 234, 102, 5053, 23,
                778, 0, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456, 3, 56, 45, 2, 6, 0, 2, 6, 7, 2, 3, 4, 0, 10,
                5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 45, 3, 67, 8, 34, 8, 3, 4, 5, 2, 3, 7, 845, 3, 67, 8, 34, 8, 3,
                4, 5, 2, 3, 7, 867, 8, 34, 8, 3, 4, 5, 2, 3, 7, 8, 20, 304, 10, 2, 30, 4, 05, 660, 234, 102, 50, 50, 100,
                200, 0, 10, 20, 30, 500, 4, 50, 100, 200, 0, 10, 20, 30, 5004, 50, 100, 200, 0, 10, 20, 30, 500, 7, 2, 3,
                4, 0, 10, 5, 67, 20, 4, 20, 111, 123, 53, 23, 778, 0, 10, 302, 10, 0, 1, 20, 3, 5, 345, 2, 12, 345, 456,
                3, 56
            };
            
            QuickSort(array, 0, array.Length - 1);
            
            foreach (int first in array)
            {
                Console.WriteLine(first);
            }

            Console.ReadLine();
        }

        static void QuickSort(int[] array, int left, int right)
        {
            int temp;
            int middle = array[(right - left) / 2 + left];
            int l = left;
            int r = right;
            
            while (l <= r)
            {
                while (array[l] < middle)
                    l++;

                while (array[r] > middle)
                    r--;

                if (l <= r)
                {
                    temp = array[l];
                    array[l] = array[r];
                    array[r] = temp;
                    l++;
                    r--;
                }
            }

            if (left < r)
                QuickSort(array, left, r);

            if (l < right)
                QuickSort(array, l, right);
        }
    }
}
