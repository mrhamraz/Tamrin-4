using System;

namespace _12._Merge_two_arrays_and_omit_duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array 1 and 2: ");              //reads size of the array
            int size1 = Convert.ToInt32(Console.ReadLine());
            int size2 = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size1];                                       //Create an array
            int[] array2 = new int[size2];                                       //Create an array

            Console.WriteLine($"Enter {size1} members of Array 1: ");
            for (int i = 0; i < size1; i++)                                      //get aray values from user and asign them
                array1[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter {size2} members of Array 2: ");
            for (int i = 0; i < size2; i++)                                      //get aray values from user and asign them
                array2[i] = Convert.ToInt32(Console.ReadLine());

            int newsize = size1 + size2;
            int[] newarray = new int[newsize];

            for (int i = 0; i < size1; i++)
                newarray[i] = array1[i];

            for (int i = 0; i < size2; i++)
                newarray[size1 + i] = array2[i];


            for (int i = 0; i < newsize ; i++)                                 //finding all duplicate values in array
            {
                for (int j = i + 1; j < newsize; j++)
                {
                    if (newarray[i] == newarray[j])                              //if any Unique found
                    {
                        for (int k = j; k < newsize-1; k++)                       
                            newarray[k] = newarray[k + 1];                       //delete the duplicate element and shift following ellemts to left

                        newsize--;                                               //decrement size after removing duplicate element

                        j--;                                                     //if shifting of elements occur then don't increase j
                    }

                }

            }

            Console.WriteLine("New array elements (duplicates omitted):");  
            for (int i = 0;i < newsize;i++)                                         //print NEW values
                Console.Write("\t"+newarray[i]);
        }
    }
}
