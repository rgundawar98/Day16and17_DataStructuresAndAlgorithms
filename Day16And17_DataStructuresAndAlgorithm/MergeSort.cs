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
            int num1 , num2 , num3 ;
            int n1= val2-val1+1;
            int n2 = val3 - val2;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for(num1=0; num1<n1;num1++)
            {
                L[num1] = arr[val1 + num1];   
            }
            for(num2=0;num2<n2;num2++)
            {
                R[num2] = arr[val2 + 1 + num2];
            }
            num1 = 0; num2 = 0; num3=0;
            while(num1 <n1 && num2 < n2)
            {
                if (L[num1] <= R[num2])
                {
                    arr[num3] = L[num1];
                    num1++;
                }
                else
                {
                    arr[num3] = R[num2];
                    num2++;
                }
                num3++;
            }
            while(num1 < n1)
            {
                arr[num3] = L[num1];
                num1++;
                num3++;
            }
            while(num2 < n2)
            {
                arr[num3] = R[num2];
                num2++;
                num3++;
            }
        }
         public static void mergesort(int[] arr , int val1,int val3)
        {
            if(val1 < val3)
            {
                int val2 = (val1 + val3) / 2;
                mergesort(arr , val2, val3);
                mergesort(arr , val2 + 1, val3);
                Merge_Sort_Opearation(arr ,val1, val2, val3);
            }
        }
    }
}
