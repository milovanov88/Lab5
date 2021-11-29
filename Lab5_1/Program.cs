using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива");
            int[] array = new int[7];
            int S = 0;
            double Avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine("Среднее арифметическое {0}", S/array.Length);
            Console.ReadKey();
        }

    }
}
