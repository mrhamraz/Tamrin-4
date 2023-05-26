using System;
using System.Linq;


namespace _13._Count_duplicate_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];                               //Create an array

            Console.WriteLine("Enter 5 numbers of Aray: ");

            for (int i = 0; i < 5; i++)                             
                array[i] = Convert.ToInt32(Console.ReadLine());     //get array values from user and asign them

            int[] count = new int[array.Max()+1];                   //new array for counting repetition of elements
                                                                    //The count[] should have a size equal to the maximum value of array[]
                                                                    // +1 because indexes start from 0


            for (int i = 0; i < array.Length; i++)
                count[array[i]]++;                                  //counting repetitions

            Console.WriteLine("Element\tRepetition");

            for (int i = 0; i < count.Length; i++)
                if (count[i] != 0)                                  //not all indexes of count[] have value
                    Console.WriteLine(i + "\t" + count[i]);

        }
    }
}
