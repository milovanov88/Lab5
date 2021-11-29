using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размнрность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Console.WriteLine("Введите элементы массива");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum += array[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
             bool res = true;
            int sumsrdiag = 0;
            for (int i = 0; i < n; i++)
            {
                int sumsrhor = 0;
                int sumsrver = 0;
                for (int j = 0; j < n; j++)
                {
                    sumsrhor += array[i, j];
                    sumsrver += array[j, i];
                    if (j + i == n - 1) sumsrdiag += array[j, i];
                }
                if (sum != sumsrhor|| sum != sumsrver)
                {
                    res = false;
                    break;
                }
            }
            if (res==true&& sumsrdiag==sum) Console.WriteLine("квадрат магический"); else Console.WriteLine("квадрат не магический");
            Console.ReadKey();
        }

    }
}
