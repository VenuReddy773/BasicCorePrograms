﻿using System;
namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Choose an Option To Execute the Program\n 1.flipcoin\n 2.LeapYearCheck\n 3.PowerOfTwo\n 4.HarmonicNumber\n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin coin = new FlipCoin();
                        coin.Play();
                        break;
                    case 2:
                        LeapYear check = new LeapYear();
                        check.LeapYearCheck();
                        break;
                    case 3:
                        PowerOfTwo pow = new PowerOfTwo();
                        pow. Power();
                        break;
                    case 4:
                        HarmonicNumber result = new HarmonicNumber();
                        result.Harmonic();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option..\n");
                        break;
                }                    
            }
        }
    }
}
