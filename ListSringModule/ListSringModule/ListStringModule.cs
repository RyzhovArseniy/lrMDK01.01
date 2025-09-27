using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSringModule
{
    public class ListStringModule
    {
         static public List<string> resultList()
         {
            Console.Write("Введите список дел:");
            int imput = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<String>();
            for (int i = 0; i< imput; i++)
            {
                list.Add(Console.ReadLine());
            }
            return list;

         }
        static public List<string> numbers(List<string> list, string text)
        {
           
            
            List<int> result = new List<int>();
            
            return result;
        }




    }
}
