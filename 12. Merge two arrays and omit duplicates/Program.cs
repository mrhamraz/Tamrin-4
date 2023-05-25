using System;

namespace _12._Merge_two_arrays_and_omit_duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array 1 and 2: ");             //Reads size of the array
            int size1 = Convert.ToInt32(Console.ReadLine());
            int size2 = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size1];                                      //Create an array
            int[] array2 = new int[size2];                                      //Create an array

            Console.WriteLine($"Enter {size1} members of Array 1: ");
            for (int i = 0; i < array1.Length; i++)                             //get aray values from user and asign them
                array1[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter {size2} members of Array 2: ");
            for (int i = 0; i < array2.Length; i++)                             //get aray values from user and asign them
                array2[i] = Convert.ToInt32(Console.ReadLine());

            int newsize = size1 + size2;
            int[] newarray = new int[newsize];

            for (int i = 0; i < array1.Length; i++)
                newarray[i] = array1[i];

            for (int i = 0; i < array2.Length; i++)
                newarray[array1.Length + i] = array2[i];

            int[] newarray2 = new int[newsize];


            for (int i = 0; i < newsize; i++)                           //finding all duplicate values in array
            {
                for (int j = i + 1; j < newsize; j++)
                {
                    if (newarray[i] == newarray[j])                             //if any duplicate found
                    {
                        /*
                        for (int k = j; k < newsize; k++)               //delete the current duplicate value
                        {
                            newarray[k] = newarray[k + 1];


                            (newsize)--;                                            //Decrement size after removing duplicate element

                            j--;                                                    // If shifting of elements occur then don't increment j
                        }*/
                        continue;
                    }

                    newarray2[i] = newarray[i];
                }
            }

            Console.WriteLine("New array elements (duplicates omitted):");
            foreach (int i in newarray2)
                Console.Write("\t"+i);                                          //print NEW values
        }
    }
}
