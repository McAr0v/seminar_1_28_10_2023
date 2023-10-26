using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_1_28_10_2023
{

    // Написать программу-калькулятор, вычисляющую выражения
    // вида a + b, a - b, a / b, a * b,
    // введенные из командной строки, и выводящую результат выполнения на экран.

    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[2]);

                string action = args[1];

                string actionName = ActionSwitch(action);

                if (actionName != "Неизвестный символ действия. Попробуйте еще раз")
                {
                    Console.Write($"Вы ввели числа: {a}, {b}. Результат {actionName} = {Calcul(a, b, action)} ");
                }

                else { Console.WriteLine(actionName); }

                

            }
            else
            {
                Console.WriteLine("Вы забыли ввести аргументы или ввели их не правильно. Введите данные в формате - (число а) ариф. действие (число b)");


            }
        }

        static int Calcul (int a, int b, string action)
        {
            
            switch (action)
            {
                case "*": { return a * b;}

                case "+": {  return a + b; }

                case "-": {  return a - b; }

                case "/": {  return a / b; }

                default: { return a + b; }
            }

        }

        static string ActionSwitch(string action)
        {

            switch (action)
            {
                case "*": { return "умножения"; }

                case "+": { return "сложения"; }

                case "-": { return "вычитания"; }

                case "/": { return "деления"; }

                default: { return "Неизвестный символ действия. Попробуйте еще раз"; }
            }

        }

    }
}
