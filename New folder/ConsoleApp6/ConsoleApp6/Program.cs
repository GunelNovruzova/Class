using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //task2 10 elementi sondan evvele duzmek
            //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //task3 2 arraydan 1 array yaratmaq
            //int[] arr = { 24, 28, 31 };
            //int[] arr1 = { 4, 9, 3 };
            //int[] arr2 = new int[arr.Length + arr1.Length];
            //for (int i = 0, a = 0; i < arr2.Length; i++)
            //{
            //    if (i < arr.Length)
            //    {
            //        arr2[i] = arr[i];
            //    }
            //    if (i == arr.Length || i > arr.Length)
            //    {
            //        arr2[i] = arr1[a];
            //        a++;
            //    }

            //}
            //foreach (var item in arr2)
            //{

            //}

            //Array.Sort(arr2);
            //Array.Reverse(arr2);
            //foreach (int item in arr2)
            //{

            //}
            //Console.WriteLine(string.Join(" ", arr2));


            //task4 min ve max element


            //int[] arr = { 2, 25, 88, 157 };
            //int min = arr[0];
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    else if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine(min);
            //Console.WriteLine(max);

                    //tek cut ededler
                    int[] arr = { 3, 6, 7, 28, 19, 10, 23, 5, 12, 14 };
                    int[] arr1 = new int[arr.Length];
                    int[] arr2 = new int[arr.Length];
                    int i, j = 0, k = 0;
                    for (i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            arr1[k] = arr[i];
                            k++;
                        }
                        else
                        {
                            arr2[j] = arr[i];
                            j++;
                        }
                    }
                    for (i = 0; i < k; i++)
                    {
                        Console.WriteLine($"Cut ededler{arr1[i]}");
                    }
                    for (i = 0; i < j; i++)
                    {
                        Console.WriteLine($"Tek ededler{arr2[i]}");
                    }
                
               

            }
        }
    }







