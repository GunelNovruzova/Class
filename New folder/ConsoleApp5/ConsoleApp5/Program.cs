using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
            {
            //soz sayi tapma
            //    string sentence = "how are you. I am Gunel";
            //int wordcount = 0;
            //for (int i = 0; i < sentence.Length - 1; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        wordcount++;
            //    }
            //}
            //wordcount++;
            //Console.WriteLine(wordcount);

            //the sayi
            string sentence = "The  string where THE word the present more than once";
            int thecount = 0;

            for (int i = 0; i < sentence.Split().Length; i++)
            {
                if (sentence.Split()[i] == "the" || sentence.Split()[i] == "The" || sentence.Split()[i] == "THE")
                {
                    thecount++;
                }
            }
            Console.WriteLine(thecount);



        }
    }
}
 
