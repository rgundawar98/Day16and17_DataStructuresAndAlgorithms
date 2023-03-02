using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17_DataStructuresAndAlgorithm
{
    public class InsertionSort
    {
        public  static void Insertion_Sort_Operation(IComparable[] arr) 
        {
            int val1, val2;
            for (val1 = 1; val1 <= arr.Length; val1++)
            {
                IComparable value = arr[val1];
                val2 = val1 - 1;
                while ((val2 > 0) && (arr[val1].CompareTo(value) > 0))
                {
                    arr[val2 + 1] = arr[val1];
                    val2--;
                }
                arr[val2 + 1] = value;
            }   
        }
    }
}
