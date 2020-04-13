using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode977
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] B = { -4, -1, 0, 3, 10 };
            int[] R=SortedSquares(B);
            foreach  (int item in R)
            {
                Console.WriteLine(item);
            }
        }

       
       public static int[] SortedSquares(int[] A)
        {
            int[] sqrd=new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                sqrd[i] = A[i] * A[i];
            }
            //Array.Sort(sqrd);
            for (int i = 0; i < 100; i++)
            {
                if (A[i] > A[i + 1])
                {
                    int temp = 0;
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                }
                else
                {

                }

                
            }
            return sqrd;
        }
    }
}
