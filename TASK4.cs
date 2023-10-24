using System;
using System.Linq;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            Random random = new Random();
            for (int i = 0;i<n;i++)
            {
                for (int j = 0;j < m;j++)
                {
                    a[i, j] = random.Next(0, 2);
                    Console.Write(" "+ a[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("k: ");
            int k = Convert.ToInt32(Console.ReadLine());
           
                for (int i = 0; i < n; i++)
                {
                    int count = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (a[i, j] == 0)
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                        }
                        if (count == k)
                        {
                            Console.WriteLine(i + 1);
                            return;
                        }
                    }
                }
                Console.WriteLine(0);
        }
    }
}
