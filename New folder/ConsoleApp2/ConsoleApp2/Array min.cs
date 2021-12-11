using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
     
     
        class Arraymin
        {
            public void Indexmin()
            {
                int[] arr = { 32, 97, 3};
                int min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }


                }
                int Index = Array.IndexOf(arr, min);
                Console.WriteLine(min);
                Console.WriteLine(Index);


            }
        }
    }


