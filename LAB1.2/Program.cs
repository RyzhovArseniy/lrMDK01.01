using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 


namespace LAB1._2
{
    class Program
    {
        static void Main()
        {
            //Задание 2 Рыдов Арсений
            int[] Array = new int[1000];
            int Random(int min, int max);
            for (int i = 0; i  < Array.Length; i++)
            {
                Array[i] = Random(-500, 500)  - 500;
            }
            Console.WriteLine("[");
            for (int i = 0; i < Array.Length -1; i++)
            {
                Console.WriteLine(Array[i] + ", ");
            }
            Console.WriteLine(Array.Length + "]");
            // Задача не сделана 
        }
    }
}
