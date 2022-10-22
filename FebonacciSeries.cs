using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class FebonacciSeries
    {
        public static void CheckFebonacci()
        {
            //taking inputs from user
            
            Console.WriteLine("Enter two numbers: ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             int num2 = Convert.ToInt32(Console.ReadLine());
            //give the Count value what we want
            Console.WriteLine("Enter the febonacci count");
            int count =Convert.ToInt32(Console.ReadLine()); 
            for( int i =1; i<=count;i++)
            {
                int num3 = num1 + num2; 
                Console.WriteLine(""+num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
