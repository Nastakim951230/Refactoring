using System;

namespace Trifonova_vk
{
    internal class Program
    {
        public static void Exponentiation(double degree_number, double degree)
        {
            Console.WriteLine("Результат = "+ Math.Pow(degree_number, degree));
        }

        public static void Remainder(double remainder_number)
        {
            double remainder_two = remainder_number % 2;
            double remainder_three = remainder_number % 3;
            if (remainder_two == remainder_three)
            {
                Console.WriteLine("Число " + remainder_number + " при деление на 2 и на 3 остается одинаковый остаток:" + remainder_two);
            }
            else
            {
                Console.WriteLine("Число " + remainder_number + " при деление на 2 и на 3  не остается одинаковый остаток");
            }
        }
        public static void ColumnOutpu(double number)
        {
            
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i+1);
                }
        }

        public static void TheEquation(double x, double y)
        {
            double result = ((1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4)));
            Console.WriteLine("Результат уравнения = "+ result);
        }

       

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вариант задания:\n1.Возведение в степень\n2.Сравнение остатков от деления на 2 и 3"+
                "\n3.Вывод числа от 1 до 10 в столбец\n4.Решение уравнение ((1 + Sin(Sqrt(x + 1))) / (Cos(12 * y - 4)))");
            try
            {
                int nomer = Convert.ToInt32(Console.ReadLine());
                switch (nomer)
                {
                    case 1:
                        {
                            Console.WriteLine(" Возведение в степень ");
                            Console.WriteLine("Введите число: ");
                            double degree_number = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите степень: ");
                            double degree = Convert.ToDouble(Console.ReadLine());
                            Exponentiation(degree_number, degree);
                        }
                        break;
                        case 2:
                        {
                            Console.WriteLine("Сравнение остатков от деления на 2 и 3");
                            Console.WriteLine("Введите число: ");
                            double remainder_number = Convert.ToDouble(Console.ReadLine());
                            Remainder(remainder_number);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Вывод числа от 1 до 10 в столбец");

                    zamena: Console.WriteLine("Введите число: ");
                        double number = Convert.ToDouble(Console.ReadLine());

                        if ((number >= 1) && (10 >= number))
                        {
                            ColumnOutpu(number);
                        }
                        else
                        {
                            if (number < 1)
                            {
                                Console.WriteLine("Число меньше чем 1");
                                goto zamena;
                            }
                            else if (number > 10)
                            {
                                Console.WriteLine("Число больше чем 10");
                                goto zamena;
                            }
                        }
                        break;
                    case 4:

                        Console.WriteLine("Решение уравнение ((1 + Sin(Sqrt(x + 1))) / (Cos(12 * y - 4)))");
                        Console.WriteLine("Введите x: ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        TheEquation(x, y);

                        break;

                }
            }
          catch 
            {
                Console.WriteLine("Ошибка");
            }
          
        }
    }
}
