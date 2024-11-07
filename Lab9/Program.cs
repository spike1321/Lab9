using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число. X= ");
            double result = 0;
            try
            {
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите целое число. Y= ");
                double y = double.Parse(Console.ReadLine());
              
                Console.WriteLine("Введите код операции: ");
                Console.WriteLine("  1 - сложение");
                Console.WriteLine("  2 - вычитание");
                Console.WriteLine("  3 - произведение");
                Console.WriteLine("  4 - частное");
                Console.Write("Ваш выбор: ");
                double a = double.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        result = x + y;
                        Console.WriteLine("Результат = {0:0.00}", result);
                        break;
                    case 2:
                        result = x - y;
                        Console.WriteLine("Результат = {0:0.00}", result);
                        break;
                    case 3:
                        result = x * y;
                        Console.WriteLine("Результат = {0:0.00}", result);
                        break;
                    case 4:
                        result = x/y;
                        if (!double.IsInfinity(result))
                            Console.WriteLine("Результат = {0:0.00}", result);
                        else
                            Console.Write("Попытка деления на нуль.");
                        break;
                    default:
                        Console.Write("Нет операции с указанным номером");
                        break;

                }
            }
           
            catch (System.FormatException)
            {
                 Console.Write("Ошибка! Входная строка имела неверный формат.");
            }
            
            Console.ReadKey();
        }
    }
}
