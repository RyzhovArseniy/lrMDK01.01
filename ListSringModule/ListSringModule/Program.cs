

using System;
using System.Collections.Generic;

namespace ListSringModule
{
    class Program
    {
        static public void Main()
        {
            List<string> value = ListStringModule.resultList();
            Console.WriteLine(value);
            Console.WriteLine("Список:" + (value.Count - 1));

            List<string> text = ListStringModule.resultList();
        }
    }
}
