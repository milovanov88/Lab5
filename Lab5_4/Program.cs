using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = random.Next(-50, 50);
                Console.Write("{0} ", array[j]);
            }
            Console.WriteLine();
            int count = 0;
            int i = 1;
            while (i < array.Length)
            {
                if (array[i] > 0 && array[i] % 2 != 0)
                {
                    count++;
                }

                i = i + 2;
            }
            Console.Write(count);
            Console.ReadKey();
        }
    }
}
