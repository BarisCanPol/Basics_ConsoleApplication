using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_ConsoleApp
{
    class Program
    {
        public static int Sum(int n)
        {
            int result = 0;                 //for-loop part
            for (int i = 0; i <= n; i++)
            {
                result = result + i;
            }

            return result;

        }

        public static int Sum_A(int n)
        {                               //while-loop part
            int result = 0, a = 0;
            while (a <= n)
            {
                result += a;
                a++;
            }

            return result;
        }

        public static int Sum_B(int n)
        {                                        //LinQ partN
            return Enumerable.Range(1, n).Sum();             
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter a number : ");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int a = 100; a > 0; a--)
            {
                Console.WriteLine(a);
                //Console.Write(a);
                //Console.Write("number : {0}", a);
            }

            Console.Write("------ \n");

            for (int b = 1; b < 101; b++)
            {
                Console.WriteLine("{0}", b);
            }

            Console.WriteLine("Sum of the from 1 to" + num + " with for-loop :" + Sum(num));
            Console.WriteLine("Sum of the from 1 to " + num + " with while-loop :" + Sum_A(num));
            Console.WriteLine("Sum of the from 1 to" + num + " with LinQ :" + Sum_B(num));

            Console.ReadKey();     
        }
        
       
    }
}
