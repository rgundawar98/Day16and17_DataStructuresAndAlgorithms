using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17_DataStructuresAndAlgorithm
{
    public class BubbleSort
    {
        public  static void Bubble_Sort_Operation() 
        {
            int[] arr = { 78, 55, 45, 98, 12 };
            int temp ;
            for(int val2=0;val2 <= arr.Length-2;val2++)
            {
                for(int val1=0;val1<= arr.Length-2;val1++)
                {
                    if(arr[val1] > arr[val1 +1])
                    {
                        temp = arr[val1 + 1];
                        arr[val1 + 1] = arr[val1];
                        arr[val1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach(int value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}
