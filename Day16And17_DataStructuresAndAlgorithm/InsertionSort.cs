using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17_DataStructuresAndAlgorithm
{
    public class InsertionSort
    {
        public  static void Insertion_Sort_Operation() 
        {
            int val1, val2;
            string temp = " ";
            string[] arr = { "Ziya", "Ronny", "Alba", "Tommy", "Shelby" };
            for (val1 = 1; val1 < arr.Length; val1++)
            {
                for(val2=val1-1;val2< arr.Length; val2++)
                {
                    while(val2>0 && arr[val2].CompareTo(arr[val2])>0)
                     {
                        temp = arr[val1];
                        arr[val2 + 1] = arr[val2];
                        arr[val2] = temp;
                     }
                }
            }   
            foreach(var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
