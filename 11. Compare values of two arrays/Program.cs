using System;

namespace _11._Compare_values_of_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[5];   //Create an array

            Console.WriteLine("Enter 5 members of first Array: ");

            for (int i = 0; i < array1.Length; i++)               //get aray values from user and asign them
                array1[i] = Console.ReadLine();

            string[] array2 = new string[5];   //Create an array
            Console.WriteLine("Enter 5 members of second Array: ");

            for (int i = 0; i < array2.Length; i++)               //get aray values from user and asign them
                array2[i] = Console.ReadLine();


            for (int i = 0; i < 5; i++)
                if (array1[i] != array2[i])                       //Compare values
                    Console.WriteLine(i);

           
        }
    }
}
