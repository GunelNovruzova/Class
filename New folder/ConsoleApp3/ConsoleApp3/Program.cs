using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arr = { 111, 112, 5 };
                int suma = 0;
                int sumb = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 100&&arr[i] <= 999)
                    {
                        suma = suma + arr[i];

                    }
                    else
                    {
                        sumb = sumb + arr[i];
                    }
                }
                Console.WriteLine(suma - sumb);

            
        }
    }
}
  
