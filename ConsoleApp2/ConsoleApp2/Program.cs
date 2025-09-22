using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main()
        {
            List <double> list = new List<double>(); ///создал пустой список без элементов
            Console.WriteLine("Исходный размер списка: " + list.Count);

            ///добавляю элементы в список 
            list.Add(1.0);
            list.Add(1.22);
            list.Add(22.33);
            list.Add(0.0);
            list.Add(-1.0);
            Console.WriteLine("Размер списка после добавления элементов: " + list.Count);


           List<string> A = new List<string> { "Собаки", "Кошки", "Крокодилы", "Кролики", "Бегемоты" };
            Console.WriteLine("Кол-во записей в списке А: " + list.Count); ///Создал список и вывел элементы



            ///Домашнее задание: добавить возможность вводить дробные числа 
            List<double> number = new List<double>();
            Console.Write("Введите дробное число: ");
            double numbers = Convert.ToDouble(Console.ReadLine());
            number.Add(numbers);
            Console.WriteLine($"Число {numbers} добавлено.");
        }




    }
    
}
