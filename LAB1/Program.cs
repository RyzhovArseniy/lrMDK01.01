﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main()
        {
            // Вариант 1 Рыжов Арсений 
            Console.WriteLine("Введите размер массива: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Length];
            Console.WriteLine("Введите элемент массива:");
            for (int i = 0; i < Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < Length; i++)
            {
                if (Array[i] > 0)
                {
                    sum += Array[i];
                }
            }
            Console.WriteLine("Сумма положительных элементов:" + sum);
         
        }
    }
}
