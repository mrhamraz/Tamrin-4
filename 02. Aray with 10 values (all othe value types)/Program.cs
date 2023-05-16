using System;

namespace _02._Aray_with_10_values__all_othe_value_types_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];   //Create an array
            //bool [] array = new bool[10];
            //char[] array = new char[10];
            //double[] array = new double[10];


            Console.WriteLine("Enter 10 strings of array: ");

            for (int i = 0; i < array.Length; i++)   //get array values from user and asign them
                array[i] = Console.ReadLine();
                //array[i] = Convert.ToBoolean(Console.ReadLine());
                //array[i] = Convert.ToChar(Console.ReadLine());
                //array[i] = Convert.ToDouble(Console.ReadLine());

            foreach (string /* bool/char/double */ i in array)  //print array values 
                Console.WriteLine(i);
        }
    }
}
