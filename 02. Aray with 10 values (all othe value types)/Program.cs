using System;

namespace _02._Aray_with_10_values__all_othe_value_types_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aray = new string[10];   //Create an array of four elements

            Console.WriteLine("Enter 10 strings of Aray: ");

            for (int i = 0; i < aray.Length; i++)   //get aray values from user and asign them
                aray[i] = Console.ReadLine();

            foreach (string i in aray)  //print aray values
                Console.WriteLine(i);
        }
    }
}
