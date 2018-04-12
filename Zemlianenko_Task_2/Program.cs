using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZemlianenkoTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // Задание 1.1 Вычислить среднее арифметическое значений в диапазоне n-m включительно
                Console.WriteLine("Задание 1");
                int n = 6;
                int m = 8;
                float average = ((float)n + (float)m) / 2;
                Console.WriteLine(average);

                /*Задание 1.2 Написать код определения суммы четных чисел в диапазоне целых значений 
    0 - n1, используя только операторы повторения (использование if запрещено). */
                Console.WriteLine("Задание 2");
                int k = 6;
                int i;
                int sum = 0;
                for (i = 0; i <= k; i = i + 2)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);

                /* Задание 1.3 Написать код определения суммы четных чисел в диапазоне целых значений n1 – n2, 
     используя условные операторы if и операторы повторения.*/
                k = 4;
                int n2 = 10;
                i = 0;
                int sumofNumb = 0;
                for (i = k; i <= n2; i++)
                {
                    if (i % 2 == 0)
                        sumofNumb = sumofNumb + i;
                }
                Console.WriteLine(sumofNumb);






            }
        }
    }
}
