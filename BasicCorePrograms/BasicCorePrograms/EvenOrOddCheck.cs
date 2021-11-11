using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOrOddCheck
    {
        public void EvenOddCheck()
        {
            Console.WriteLine("Enter The Number To Check Even or Odd");
            int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Entered Number Is Even");
                }
                else
                {
                    Console.WriteLine("Entered Number Is Odd");
                }            
        }
    }
}
