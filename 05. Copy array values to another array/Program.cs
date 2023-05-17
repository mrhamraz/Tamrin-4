using System;

namespace _05._Copy_array_values_to_another_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array1 = new double[10];   //Create an array
            //double[] array2 = new double[10];


            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < array1.Length; i++)   //get array values from user and asign them
                array1[i] = Convert.ToDouble(Console.ReadLine());

            //array2 = array1;             //copy an array to another
            double[] array2 = array1;

            foreach (double i in array2)  //print array values
                Console.WriteLine(i);


        }
    }
}
