using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;
            int[] a = new int[n * m];
            int[] a1 = new int[n * m];
            int[] res = new int[n * m];
            Random rand = new Random();
            for (int i = 0; i<n*m;i++)
            {
                a[i] = rand.Next(2,9);
               
            }

            for (int j = 0;j<n*m;j++) 
            {
                a1[j] = rand.Next(2,9);
                
            }
            for (int i = 0; i < n * m; i++)
            {
                Console.Write(a[i] + " ");
                if ((i + 1) % n == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n * m; i++)
            {
                Console.Write(a1[i] + " ");
                if ((i + 1) % n == 0)
                {
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += a[i * n + k] * a1[k * n + j];
                    }
                    res[i * n + j] = sum;
                }
            }
            Console.WriteLine("\n"+"Результат умножения матриц:");
            for (int i = 0; i < n * m; i++)
            {
                Console.Write(res[i] + " ");
                if ((i + 1) % n == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
