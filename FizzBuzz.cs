using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(100);
            
        }
        static List<string> FizzBuzz(int n)
        {
            List<string> res = new List<string>();
            int j = 1;
            while(j <= n)
            {
                if(j%3==0 && j % 5 == 0)
                {
                    res.Add("FizzBuzz");
                }
                else if (j % 3 == 0)
                {
                    res.Add("Fizz");
                }
                else if(j%5==0)
                {
                    res.Add("Buzz");
                }
                else
                {
                    res.Add(j.ToString());
                }
                j++;
                
                
            }
            foreach (string word in res)
            {
                Console.WriteLine(word);
            }
            return res;

        }
    }
}
