using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix1 = new string[3][];//הגדרה של גודל המערך

            matrix1[0] = new string[] { "main", "up", "sub" };
            matrix1[1] = new string[] { "down", "center", "up" };
            matrix1[2] = new string[] { "sub", "down", "main" };

            foreach(string[] matrixRow in matrix1)
            {
                foreach(string matrixCol in matrixRow)
                {
                    Console.Write($"[ {matrixCol} ]");
                }
                Console.WriteLine();
            }
        }
    }
}
