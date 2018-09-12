/*
1. Ввести  посаду(рядок, string) працівника та кількість відпрацьованих годин.
На кожній посаді своя тарифна ставка оплати години робочого часу.
Вивести заробітну плату працівника. Використати switch.
 */

using System;


namespace _01_salary_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input position of employee:\t");
            string position = Console.ReadLine();
            Console.Write("Input q-ty hours of employee:\t");
            int hours = Convert.ToInt32(Console.ReadLine());

            switch(position)
            {
                case "Programmer":
                    Console.Write($"\n{position} worked {hours} hours and have salary ${hours * 10}\n");
                    break;
                case "Manager":
                    Console.Write($"\n{position} worked {hours} hours and have salary ${hours * 12}\n");
                    break;
                case "HR":
                    Console.Write($"\n{position} worked {hours} hours and have salary ${hours * 8}\n");
                    break;
                case "Tutor":
                    Console.Write($"\n{position} worked {hours} hours and have salary ${hours * 11}\n");
                    break;
                default:
                    Console.WriteLine($"Position {position} don't have in our bases\n");
                    break;
            }
            Console.ReadLine();
        }
    }
}
