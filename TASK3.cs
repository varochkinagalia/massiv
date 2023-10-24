using System;
using System.Collections.Generic;

namespace ConsoleApp22
{
    class Program
    {
        
        static void inicialization( int n, int[] m )
        {
            Random random = new Random();
            for (int i = 0;i<n;i++)
            {
                m[i] = random.Next(0,20);
            }
            pechat(m);
        }
        static void plus(int n,int n1)
        {
            int[] a = new int[n];
            int[] a1 = new int[n1];
            Console.WriteLine("первый массив");
            inicialization(n, a);
            Console.WriteLine("\nвторой массив");
            inicialization(n1, a1);
            Console.WriteLine(" ");
            int[] summa = new int[a.Length];
           
            if (a.Length == a1.Length)
            {
                for (int i = 0;i<a.Length;i++)
                {
                   summa[i] = a[i] + a1[i];
                }
                pechat(summa);
            }
            else
            {
                Console.WriteLine("\nСложение невозможно");
            }
        }
        static void umnogenie(int k, int chislo)
        {
            
            int[] m = new int[k];
            inicialization(k,m);
            for (int i = 0;i<m.Length;i++ )
            {
                m[i] = chislo * m[i];
            }
            pechat(m);

        }
        static void srednee_znachenie(int l1,int l2)
        {
            int[] a = new int[l1];
            int[] a1 = new int[l2];
            Console.WriteLine("первый массив");
            inicialization(l1, a);
            Console.WriteLine("\nвторой массив");
            inicialization(l2, a1);
            Console.Write("общее значение - ");
            for (int i = 0; i< l1;i++)
            {
                for (int j = 0;j<l2;j++)
                {
                    if (a[i] == a1[j])
                    {
                        Console.Write(a[i]+"\t");
                    }
                }
            }
        }
        static void pechat(int[]m)
        {
            foreach (int i in m)
            {
                Console.Write(i + " ");
            }
            Console.Write( "\n");
        }
        static void uporyadok (int[]m)
        {
            Console.WriteLine("Изначальный массив: ");
            pechat(m);
            int n;
            for (int i = 0; i< m.Length-1;i++)
            {
                for (int j = i+1;j<m.Length;j++)
                {
                    if (m[i]<m[j])
                    {
                        n = m[i];
                        m[i] = m[j];
                        m[j] = n;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            pechat(m);
        }
        static void min_max_sredn(int[] m)
        {
            Console.WriteLine("Изначальный массив: ");
            pechat(m);
            int max = -10000000;
            int min = 100000000;
            int sum = 0;
            for (int i = 0; i < m.Length ; i++)
            {
                sum += m[i];
                if (m[i]>max)
                {
                    max = m[i];
                }
                if (m[i]<min)
                {
                    min = m[i];
                }
            }
            int sredn = sum / m.Length;
            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Cреднее значение: " + sredn);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1-инициализация массива");
            Console.WriteLine("2-сложение массивов");
            Console.WriteLine("3-умножение на число ");
            Console.WriteLine("4-среднее значение массива");
            Console.WriteLine("5-печать массива");
            Console.WriteLine("6-упорядочить массив");
            Console.WriteLine("7-мин.макс.средн. значение ");
            
            Console.Write("Введите номер операции: ");
            int nomer = Convert.ToInt32(Console.ReadLine());
            switch(nomer)
            {
                case 1:
                    Console.WriteLine("Инициализация массива: ");
                    int n;
                    Console.Write("Введите размер массива: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] massiv = new int[n];
                    inicialization(n,massiv);
                    break;
                case 2:
                    Console.WriteLine("Сложение массива: ");
                    int n1;
                    int n2;
                    Console.Write("Введите размер массива 1: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите размер массива 2: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    plus(n1, n2);
                    break;
                case 3:
                    Console.WriteLine("Умножение на число: ");
                    Console.Write("Введите размер массива: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число: ");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    umnogenie(k, chislo);
                    break;
                case 4:
                    Console.WriteLine("Среднее значение массива: ");
                    int l1;
                    int l2;
                    Console.Write("Введите размер массива 1: ");
                    l1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите размер массива 2: ");
                    l2 = Convert.ToInt32(Console.ReadLine());
                    srednee_znachenie(l1, l2);
                    break;
                case 5:
                    Console.WriteLine("Печать массива: ");
                    int[] ma = new int[] { 1, 3, 7, 90, 77, 6, 55, 0, 100000 };
                    pechat(ma);
                    break;
                case 6:
                    Console.WriteLine("Упорядочить массив: ");
                    int[] ma1 = new int[] { 1, 3, 7, 90, 77, 6, 55, 0, 100000 };
                    uporyadok(ma1);
                    break;
                case 7:
                    Console.WriteLine("Мин.макс.среднее значения массив: ");
                    int[] ma2 = new int[] { 1, 3, 7, 90, 77, 6, 55, 0, 100000 };
                    min_max_sredn(ma2);
                    break;
                default:
                    Console.WriteLine("Операции с таким номером не существует: ");
                    break;
            }
        }
    }
}
