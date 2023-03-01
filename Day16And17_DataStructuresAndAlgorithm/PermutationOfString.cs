using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17_DataStructuresAndAlgorithm
{
    public class PermutationOfString
    {
        public static void Permute(string str ,int startindex ,int endindex)
        {
            if(startindex == endindex)
                Console.WriteLine(str);
            else
            {
                for(int i=1;i<=endindex;i++)
                {
                    str = Swap(str, startindex, endindex);
                    Permute(str, startindex+1, endindex);
                    str = Swap(str, startindex+1, endindex);
                }
            }
        }
        public static string Swap(string val , int val1 , int val2)
        {
            char temp;
            char[] charArray = val.ToCharArray();
            temp = charArray[val1];
            charArray[val1] = charArray[val2];
            charArray[val2] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
