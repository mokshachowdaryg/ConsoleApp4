/*
Author: Moksha Chowdary Guntupalli
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
     Bubble Sort Algorithm. No input
    is required for the script. It will execute without 
    input against two pre-populated arrays. 
*/
using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 62, 5, 16, 4, 10 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    // Swap arr[i-1] and arr[i]
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;

                    swapped = true;
                }
            }

            // After each pass, the largest element is guaranteed to be at the end,
            // so we can reduce the size of the array to be considered in the next pass.
            n--;
        } while (swapped);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
