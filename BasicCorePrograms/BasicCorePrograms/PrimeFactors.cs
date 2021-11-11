using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactors
    {
        public void Factors()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=number;i++)
            {
                while(number % i == 0)
                {
                    number /= 2;
                    Console.WriteLine(i+" ");
                }
            }
            if(number>2)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
