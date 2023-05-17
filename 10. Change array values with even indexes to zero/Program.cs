using System;

namespace _10._Change_array_values_with_even_indexes_to_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");     //Reads size of the array
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];   //Create an array

            Console.WriteLine($"Enter {size} members of Array: ");

            for (int i = 0; i < array.Length; i++)               //get aray values from user and asign them
                array[i] = Convert.ToInt32(Console.ReadLine());


            foreach (int i in array)                              //print values
                Console.Write("\t" + i);                

            for (int i = 0; i < array.Length; i++)
                if (i % 2 == 0)                                    //Change array values with even indexes to zero
                    array[i] = 0;

            Console.WriteLine("\n");

            foreach (int i in array)                                //print NEW values
                Console.Write("\t" + i);
        }
    }
}
