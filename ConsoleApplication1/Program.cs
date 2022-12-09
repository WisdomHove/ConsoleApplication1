using System.Collections.Generic;
using System.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
            var list3 = list1.Intersect(list2);

            Console.WriteLine(string.Join(" ", list3));

            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"

            int a = list1.Length;
            int b = list2.Length;

            for(int i = 0; i < a; i++)
            {
                int j;
                for (j = 0; j < b; j++)
                    if (list1[i] == list2[j])
                        break;
                    if(j == b)
                    Console.Write(list1[i]+" ");
                    
            }
            Console.WriteLine();

            //Show the elements from list 2, but is not found in list1. E.g 6 7"

            for (int i = 0; i < b; i++)
            {
                int j;
                for (j = 0; j < a; j++)
                    if (list2[i] == list1[j])
                        break;
                if (j == a)
                    Console.Write(list2[i]+" ");

            }
            Console.WriteLine();

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
