using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a;
                double b;
                double result = 0;
                string use;

                Console.Write("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Что вы хотите сделать: ");
                use = Convert.ToString(Console.ReadLine());

                if (use == "+")
                {
                    result = a + b;
                }
                else if (use == "-")
                {
                    result = a - b;
                }
                else if (use == "*")
                {
                    result = a * b;
                }
                else if (use == "/")
                {
                    result = a / b;
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор");
                }

                Console.WriteLine("Ответ: " + result);

                string answer;
                Console.WriteLine("Хотите выйти?");
                answer = Convert.ToString(Console.ReadLine());
                if (answer == "Yes")
                {
                    return;
                }
            }
        }
    }
}
