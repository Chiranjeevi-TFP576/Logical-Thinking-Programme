using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int num = 0;
            int sum = 0;
            //taking input fron user
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                //Factors of a input value
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
                if(num == sum)
                {
                    Console.WriteLine(" is perfect number" + num);
                }
                else
                {
                    Console.WriteLine(" is not a perfect number" +num);
                }
        }
    }
}
