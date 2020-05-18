using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] arr = { 2, -10, 4, 20, -50, -98 };
            ArrayOfMultiples(7, 5);
            CountPosSumNeg(arr);
            //divisibleByFive(9);
            ProfitableGamble(0.2, 5, 9);
            int[] values = { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 };
            SumSmallest(values);
            ValidatePIN("");
        }
        public static int[] ArrayOfMultiples(int num, int length)
        {
            
            
             int [] totalarray = new int[length];

            for (int i =0; i<= length;i++)
            {
                if(i != 0 && i<length)
                {
                    totalarray[i] = num + totalarray[i-1];
                }
                else if (i==0)
                {
                    totalarray[i] = num + totalarray[i];
                }

            }
            return totalarray;
        }

        public static int[] CountPosSumNeg(double[] arr)
        {
            return new[] { arr.Count(n => n > 0), (int)arr.Sum(n => n < 0 ? n : 0)};
        }
        //public static bool divisibleByFive(int n)
        //{
        //    for(int m=0;m< n/2; m++)
        //    {
        //        if (n % m == 0 )
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    return true;

        //}
        public static bool ProfitableGamble(double prob, int prize, double pay)
        {
            if(prob * prize >pay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int SumSmallest(int[] values)
        {

            Array.Sort(values);
            int count = 0;
            int result = 0;
            for (int i = 0; i < values.Length &&  count < 2; i++)
            {
                if(values[i]>0)
                {
                    result += values[i];
                    count++;
                }
            }
            //int c = 0;
            //int[] b = new int[10];
            //for (int i =0; i<values.Length;i++)
            //{
            //    int a = values[i];
                
            //    if(a>0)
            //    {
                    
            //        b[i] = values[i] + b[i];
            //    }

            //}
            //Array.Sort(b);
            //for(int j=0; j<b.Length;j++)
            //{
            //    int k = b[j];

            //    if(k>0)
            //    {
            //        c = b[j];
                    
                    
            //    }
            //}
            //for(int d=0;d<=1;d++)
            //{
            //    int k = b[d];
            //    if(k>0)
            //    {
            //         c = b[d] + c;
            //    }
            //}
            return result;
        }

        public static bool ValidatePIN(string pin)
        {
            int count = 0;
            int  charcount=0;
            foreach(char c in pin)
            {
                count++;
                if(char.IsLetter(c))
                {
                    charcount++;
                }
            }
            if (count <= 4 && charcount == 0 && count !=0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
            
        }
    }
}
