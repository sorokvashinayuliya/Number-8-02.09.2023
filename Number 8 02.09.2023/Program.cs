using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_8_02._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
            /*Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее
в начале. Найти полученное число.*/
        {
            Console.WriteLine("Введите трёхзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number % 10;
            int b = number / 10;
            Console.WriteLine(a * 100 + b);

        }
    }
}
