using System;

namespace Smaller_Elements_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Given an array of integers, return a new array where each element in the new array\n" +
                $"is the number of smaller elements to the right of that element in the original array.\n\n");
            DoCalc MyMath = new DoCalc { };                     
            int[] arr = { 3, 4, 9, 6, 1, 0, 6, 5, 3, 2, 6 };    // TEST CASE

            Console.WriteLine($"Starting array: {MyMath.PrintNewArray(arr)}");
            Console.WriteLine($"Number of smaller elements: {MyMath.PrintNewArray(MyMath.CountElements(arr))}");
        }
    }

    class DoCalc
    {
        public int[] CountElements(int[] array)
        {
            int[] newArray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                for (int i2 = i; i2 < array.Length; i2++)
                {
                    if (i == array.Length - 1)
                        newArray[array.Length - 1] = 0;
                    else if (array[i2] < array[i])
                        newArray[i]++;
                }
            }
            return newArray;
        }

        public string PrintNewArray(int[] array) // Find a better way to print arrays..... :(
        {
            string newArr = "";
            foreach(int num in array)
            { newArr += Convert.ToString(num) + " "; }
            return newArr;
        }
    }
}
