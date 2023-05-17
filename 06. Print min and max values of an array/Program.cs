using System;
using System.Linq;

namespace _06._Print_min_and_max_values_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];   //Create an array

            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < array.Length; i++)   //get aray values from user and asign them
                array[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
         
        }
    }
}
