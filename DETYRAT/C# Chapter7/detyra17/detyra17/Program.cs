﻿using System;

namespace detyra17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid]) temp[tmp_pos++] = numbers[left++];
                else temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end) temp[tmp_pos++] = numbers[left++];

            while (mid <= right) temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

  
    }
}