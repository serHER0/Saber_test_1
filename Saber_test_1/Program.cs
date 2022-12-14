using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber_test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var s = Convert.ToInt32(Console.ReadLine());
            Swap(s, out string res);
            Console.WriteLine("result: " + res);
            Console.ReadLine();

        }

        //метод для обмена элементов
        static void Swap(int a, out string res)
        {
            string result = "";
            if (a % 2 == 1)
            {
                result = "1";
                a = a - 1;
                while (a / 2 >= 1 || a == 1)
                {
                    if (a % 2 == 0)
                    {
                        a = a / 2;
                        result = "0" + result;
                    }
                    else if (a % 2 == 1)
                    {
                        a = (a - 1) / 2;
                        result = "1" + result;
                    }
                }
            }
            else
            {
                while (a / 2 >= 1 || a == 1)
                {
                    if (a % 2 == 0)
                    {
                        a = a / 2;
                        result = "0" + result;
                    }
                    if (a % 2 == 1)
                    {
                        a = (a - 1) / 2;
                        result = "1" + result;
                    }
                }
            }
            res = result;
        }

    }
}
