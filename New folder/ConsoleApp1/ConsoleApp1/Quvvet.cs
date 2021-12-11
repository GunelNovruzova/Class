using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Quvvet
    {
        public void Quvvet1(int num)
        {
            
            bool result = false;
            for (int i = 1; i < num; i*=2)
            {
                if (num==i*2)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
               
            }
            if (result)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
