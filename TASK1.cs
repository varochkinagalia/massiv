using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 2;
            int[] massiv = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] vstavka = new int[] { 67, 78, 99 };
            int N = massiv.Length;
            int M = vstavka.Length;
            Array.Resize(ref massiv, massiv.Length + M);
            Array.Copy(massiv, K, massiv, K+M, N-K);
            Array.Copy(vstavka, 0, massiv,K, M);
            foreach (int i in massiv)
            {
                Console.Write(i+" ");
            }


        }
    }
}
