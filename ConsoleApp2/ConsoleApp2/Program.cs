using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
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


        }
    }
}
