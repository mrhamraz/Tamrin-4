using System;

namespace _09._Divide_even_or_odd_values_of_an_array_into_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];   //Create an array

            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < array.Length; i++)   //get array values from user and asign them
                array[i] = Convert.ToInt32(Console.ReadLine());

            int[] even = new int[10];   //Create even an odd arrays
            int[] odd = new int[10];

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)         //check even or odd and assign into thoese arrays
                    even[i] = array[i];
                else
                    odd[i] = array[i];


            Console.WriteLine("Even array:");

            for (int i = 0; i < even.Length; i++)
            {
                if (even[i] == 0)                  //print values (except zero values)
                    continue;
             Console.Write("\t" + even[i]);
            }


            Console.WriteLine("\nOdd array:");

            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] == 0)                   //print values (except zero values)
                    continue;
             Console.Write("\t" + odd[i]);
            }
        }
    }
}

