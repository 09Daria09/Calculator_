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
            Console.WriteLine("Введите задание, которое хотите проверить: ");
            string test = Console.ReadLine();

            if (test == "0")
            {
                //Calculator
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
            if (test == "1")
            {
                //Test 1
                Console.WriteLine(" It's easy to win forgiveness for being wrong; being right is what gets you into real trouble. ");
                Console.WriteLine(" being right is what gets you into real trouble. ");
                Console.WriteLine(" Bjarne Stroustrup ");
            }
            if (test == "2")
            {
                //Test 2
                int size = 5;
                int sum = 0;
                int multiplication = 1;
                int[] numbers = new int[size];
                Console.WriteLine("Введите пять чисел: ");
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < (size < str.Length ? size : str.Length); ++i)
                    numbers[i] = Convert.ToInt32(str[i]);

                int min = numbers[0];
                int max = numbers[0];

                Console.WriteLine("Массив:");
                for (int i = 0; i < size; ++i)
                {
                    if (min > numbers[i])
                        min = numbers[i];
                    if (max < numbers[i])
                        max = numbers[i];

                    multiplication *= numbers[i];
                    sum += numbers[i];

                    Console.Write("{0} ", numbers[i]);
                }
                Console.Write("\nСумма чисел: {0}\nМинимальное число: {1}\nМаксимальное число: {2}\nПроизвидение чисел: {3}\n",
                    sum, min, max, multiplication);
            }
            if (test == "3")
            {
                int size = 6;
                string newNum = "";

                Console.WriteLine("Введите шестизначное число: ");
                string num = Console.ReadLine();

                for (int i = size - 1; i >= 0; i--)
                    newNum += num[i];

                Console.Write("\nИзначальное число: {0}\nЗеркальное число: {1}\n", num, newNum);
            }
            if (test == "4")
            {
                int size = 2;
                int[] numbers = new int[size];

                Console.WriteLine("Введите границы числового диапазона: ");
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < (size < str.Length ? size : str.Length); ++i)
                    numbers[i] = Convert.ToInt32(str[i]);

                int sizeOfArray = numbers[1] - numbers[0];
                int[] array = new int[sizeOfArray];
                int index = -1;

                while (true)
                {
                    index++;
                    if (index == 0)
                    {
                        array[index] = numbers[0];
                    }
                    else if (index == 1)
                    {
                        if (array[index - 1] == 0)
                        {
                            array[index] = 1;
                        }
                        else
                        {
                            array[index] = numbers[0];
                        }
                    }
                    else
                    {
                        array[index] = array[index - 1] + array[index - 2];
                    }
                    if (array[index] > numbers[1])
                    {
                        return;
                    }
                    Console.Write("{0} ", array[index]);
                }
            }
            if (test == "5")
            {
                Console.Write("Введите значение A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A > B)
                {
                    return;
                }
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write(i);
                    Console.WriteLine();
                }
            }
            if(test == "6")
            {
                Console.Write("Введите длину линии: ");
                int lenght = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите символ заполнения: ");
                string ch = Console.ReadLine();
                Console.Write("Введите направление линии \n1.Горизонтальная \n2.Вертикальная:\n");
                int num = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < lenght; i++)
                {
                    if(num == 1)
                    {
                        Console.Write(ch);
                    }
                    if(num == 2)
                    {
                        Console.WriteLine(ch);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
