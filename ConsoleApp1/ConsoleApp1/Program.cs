using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[3] { "размарин", "мясо", "соль" };
            A[2] = "собака";
            Console.WriteLine(A[0]);
            Console.WriteLine(A[1]);
            Console.WriteLine(A[2]);

            string[] B = new string[3];
            B[0] = A[2];
            B[1] = A[1];
            B[2] = A[0];
            Console.WriteLine(B[0]);
            Console.WriteLine(B[1]);
            Console.WriteLine(B[2]);

            int[] C = new int[10000];
            for (int m = 0; m < C.Length; m++)
            { 
                C[m] = 1 + m;
            }
            Console.WriteLine("[");
            for (int m = 0; m < C.Length -1; m++)
            {
                Console.WriteLine(C[m] + ", ");
            }
            Console.WriteLine(C.Length + "]");
        }
    }
}
