using System;

namespace _3._Print_aray_values_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];   //Create an array

            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < array.Length; i++)   //get aray values from user and asign them
                array[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nArray in reverse order: ");  //Print array in reversed order
            for (int i = array.Length - 1 ; i >= 0; i--)
                Console.WriteLine(array[i]);
        }
    }
}
