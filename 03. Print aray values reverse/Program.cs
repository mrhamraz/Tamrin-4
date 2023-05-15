using System;

namespace _3._Print_aray_values_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aray = new int[3];   //Create an array of four elements

            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < aray.Length; i++)   //get aray values from user and asign them
                aray[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nArray in reverse order: ");  //Print array in reversed order
            for (int i = aray.Length - 1 ; i >= 0; i--)
                Console.WriteLine(aray[i]);
        }
    }
}
