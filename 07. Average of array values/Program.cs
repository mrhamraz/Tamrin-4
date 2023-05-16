using System;
using System.Linq;

namespace _07._Average_of_array_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");  //Reads size of the array
            int size = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[size];   //Create an array

            Console.WriteLine($"Enter {size} members of Array: ");

            for (int i = 0; i < array.Length; i++)   //get aray values from user and asign them
                array[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Average is {array.Sum()/size}");    //average of values
        }
    }
}
