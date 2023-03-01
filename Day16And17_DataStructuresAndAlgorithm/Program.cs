using System;

namespace Day16And17_DataStructuresAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataStructure and algorithms Practices");
            Console.WriteLine("1.Permutation Of String\n4.Bubble Sort\n6.Anagram\n7.Prime Number");
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
