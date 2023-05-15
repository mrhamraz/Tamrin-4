using System;

namespace _01._Aray_with_10_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aray = new int[10];   //Create an array of four elements

            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < aray.Length; i++)   //get aray values from user and asign them
                aray[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int i in aray)  //print aray values
                Console.WriteLine(i);
        }
    }
}
