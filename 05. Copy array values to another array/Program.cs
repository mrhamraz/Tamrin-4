using System;

namespace _05._Copy_array_values_to_another_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] aray1 = new double[3];   //Create an array
            double[] aray2 = new double[3];


            Console.WriteLine("Enter 10 numbers of Aray: ");

            for (int i = 0; i < aray1.Length; i++)   //get array values from user and asign them
                aray1[i] = Convert.ToDouble(Console.ReadLine());

            aray2 = aray1;  //copy an array to another

            foreach (double i in aray2)  //print array values
                Console.WriteLine(i);


        }
    }
}
