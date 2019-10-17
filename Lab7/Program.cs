using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 
            int x = 10;

            do
            {
                Console.WriteLine(x);
                x = x + 10;
            } while (x <= 100);
            

            //Part 2
            int sum = 0;
            for (int num = 1; num <= 20;num++) 
            {
                sum=num + sum;
            }
            Console.WriteLine("The sum is" + sum);
            Console.ReadKey();

            //Part 3
            int x = 1;
            for (int x = 1; x<=1; x )
            {

            }    



        }
    }
}
