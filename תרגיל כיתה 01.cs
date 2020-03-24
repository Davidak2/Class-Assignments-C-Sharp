using System;

namespace מטלת_כיתה
{
    class Program
    {
        static void Main(string[] args)
        {
            //מה אורך המערך
            Console.WriteLine("enter length of array:");
            int LenghtOfArray = Convert.ToInt32(Console.ReadLine());

            //מה המספר שמכפילים
            Console.WriteLine("enter number to multiply:");
            int NumToMult = Convert.ToInt32(Console.ReadLine());

            //הגדרה של אורך המערך
            int[] arr = new int[LenghtOfArray];


            Console.WriteLine($"num of elements:{LenghtOfArray}, num to mult:{NumToMult}");

            //ללולאת הדפסה
            for(int i=0;  i<arr.Length; i++)
            {
                arr[i] = i * NumToMult;
                Console.WriteLine(arr[i] + "");
            }

            Console.ReadKey();
        }
    }
}
