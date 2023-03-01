using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17_DataStructuresAndAlgorithm
{
    public class PrimeNumber
    {
        public static void Prime_Number_Range()
        {
            int Start, Range, count = 0;
            Console.WriteLine("Enter the starting range");
            Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the range");
            Range = Convert.ToInt32(Console.ReadLine());
            for (int val1 = 1; val1 <= Range; val1++)
            {
                for (int val2 = 1; val2<= Range; val2++)
                {
                    if (val1%val2 == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(val1);
                }
                count = 0;
            }
        }
    }
}
