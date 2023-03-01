using System;

namespace Day16And17_DataStructuresAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataStructure and algorithms Practices");
            Console.WriteLine("1.Permutation Of String\n4.Bubble Sort\n5.Merge Sort\n6.Anagram\n7.Prime Number");
            Console.WriteLine("Choose option from above");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string str = "ABC";
                    int len =str.Length;
                    PermutationOfString.Permute(str ,0,len-1);
                    break;
                case 4:
                    BubbleSort.Bubble_Sort_Operation();
                    break;
                case 5:
                    int[] arr = new int[6] { 76, 89, 23, 1, 55, 78 };
                    int n = 6, num;
                    Console.WriteLine("Merge sort ");
                    Console.WriteLine("Initial array is:");
                    for(num= 0; num < arr.Length;num++)
                    {
                        Console.WriteLine(arr[num]+" ");
                    }
                    MergeSort.mergesort(arr, 0, n - 1);
                    Console.WriteLine("Sorted array is:");
                    for(num= 0; num < n;num++)
                    {
                        Console.WriteLine(arr[num]+" ");
                    }
                    break;
                case 6:
                    Anagram.Anagram_Operation();
                    break;
                case 7:
                    PrimeNumber.Prime_Number_Range();
                    break;

            }
        }
    }
}
