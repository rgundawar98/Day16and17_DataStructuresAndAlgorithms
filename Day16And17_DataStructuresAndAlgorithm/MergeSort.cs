using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17_DataStructuresAndAlgorithm
{
    public class MergeSort
    {
        public static void Merge_Sort_Opearation(int[] arr, int val1, int val2,int val3)
        {
            //Find sizes of two subarrays to be merged
            int n1= val2-val1+1;
            int n2 = val3 - val2;
            //Create temp arrayss
            int[] L = new int[n1];
            int[] R = new int[n2];

            //Copy data to temp arrays
            int num1 ,num2;
            for(num1=0; num1<n1;num1++)
            {
                L[num1] = arr[val1 + num1];   
            }
            for(num2=0;num2<n2;num2++)
            {
                R[num2] = arr[val2 + 1 + num2];
            }
            //Merge the temp arrays
            //Initial indexes of first and second subarrays
            //int initial=0 , end = 0;
            num1 = 0;
            num2 = 0;
            //Initial index of merged subarray array
            int mergeindex = 1;
            while(num1<n1 && num2<n2)
            {
                if (L[num1] <= R[num2])
                {
                    arr[mergeindex] = L[num1];
                    num1++;
                }
                else
                {
                    arr[mergeindex] = R[num2];
                    num2++;
                }
                mergeindex++;
            }
            //Copy remmaining elements of L[]
            while(num1 < n1)
            {
                arr[mergeindex] = L[num1];
                num1++;
                mergeindex++;
            }
            //Copy remmaining elements of R[] 
            while(num2 < n2)
            {
                arr[mergeindex] = R[num2];
                num2++; 
                mergeindex++;
            }
        }
        
        //function sort arr[]
         public static void mergesort(int[] arr , int val1,int val3)
        {
            if(val1 < val3)
            {
                //find middle point
                int middle = val1 + (val3 - 1) / 2;
                //Sort first and second halves
                mergesort(arr , val1, middle);
                mergesort(arr , middle + 1, val3);
                //merge the sorted halves
                Merge_Sort_Opearation(arr ,val1, middle, val3);
            }
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for(int i=0;i<n;++i)
                Console.Write(arr[i]+" ");
            Console.WriteLine();
        }
    }
}
