using System;

namespace _4._Sum_of_values_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");  //Reads size of the array
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];   //Create an array

            Console.WriteLine($"Enter {size} members of Array: ");


            int sum = 0;
            for (int i = 0; i < array.Length; i++)   //get aray values from user and asign them
            { 
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine($"sum is {sum}");
            
        }
    }
}
