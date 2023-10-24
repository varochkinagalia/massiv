using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int N = massiv.Length;
            Array.Resize(ref massiv, massiv.Length+massiv.Length / 2);
            Array.Copy(massiv, 0, massiv, N, N/2);
            Array.Copy(massiv, N / 2, massiv, 0, N- N / 2);
            Array.Copy(massiv, N, massiv,  N-N/2,N/2);
            Array.Resize(ref massiv, massiv.Length-N/2);
            foreach (int i in massiv)
            {
                Console.Write(i + " ");
            }
        }
    }
}
