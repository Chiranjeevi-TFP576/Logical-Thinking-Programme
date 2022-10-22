using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class PrimeNumber
    {
        public static void CheckPrime()
        {
            int i,num, prime=0;
            //taking inputs for Checking prime
            Console.WriteLine("Enter a number whether it is Prime or not");
            num = Convert.ToInt32(Console.ReadLine());
            for ( i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    prime++;
                }
            }
            if (prime == 2)
            {
                Console.WriteLine("{0} is prime Number",num);
            }
            else
            {
                    Console.WriteLine("Not a prime Number",num);
            }
        }
    }
}
