using System;

namespace _01._Aray_with_10_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];   //Create an array

            Console.WriteLine("Enter 10 numbers of array: ");

            for (int i = 0; i < array.Length; i++)   //get array values from user and asign them
                array[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int i in array)  //print array values
                Console.WriteLine(i);
        }
    }
}
