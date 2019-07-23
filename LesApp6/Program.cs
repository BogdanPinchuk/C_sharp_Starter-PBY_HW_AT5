using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp6
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення дати
            Console.WriteLine("Введіть дату:\n");
            Console.Write("\tДень: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("\tМісяць:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("\tРік:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // вибрано обмеження в 9999 
            // для використання спеціальних методів відображення дати
            if (0 <= year && year <= 9999)
            {
                switch (month)
                {
                    // спочатку ідуть номера місяців,
                    //а в кінці додатково додано число 13 
                    // щоб усунути повторення коду
                    case 1:     // Січень
                    case 3:     // Березень
                    case 5:     // Травень
                    case 7:     // Липень
                    case 8:     // Серпень
                    case 10:    // Жовтень
                    case 12:    // Грудень
                        if (1 <= day && day <= 31)
                        {
                            goto case 13;
                        }
                        else
                        {
                            goto default;
                        }
                    case 4:     // Квітень
                    case 6:     // Червень
                    case 9:     // Вересень
                    case 11:    // Листопад
                        if (1 <= day && day <= 30)
                        {
                            goto case 13;
                        }
                        else
                        {
                            goto default;
                        }
                    case 2:     // Лютий
                        if (year % 4 == 0)
                        {
                            if (1 <= day && day <= 29)
                            {
                                goto case 13;
                            }
                            else
                            {
                                goto default;
                            }
                        }
                        else
                        {
                            if (1 <= day && day <= 28)
                            {
                                goto case 13;
                            }
                            else
                            {
                                goto default;
                            }
                        }
                    case 13:    // виведення дати
                        // використання структури DataTime - для зручнішого виведення
                        // https://metanit.com/sharp/tutorial/19.1.php
                        Console.WriteLine(new DateTime(year, month, day).ToLongDateString());
                        if (year % 4 == 0)
                        {
                            Console.WriteLine("\nДаний рік - високосний.");
                        }
                        break;
                    default:
                        Console.WriteLine("Дана дата неможлива.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Для розрахунку доступні лише дати від Різдва Христового!" +
                    "\nТобто в діапазоні від 0 до 9999 року.");
            }

            #region Повторення
            Console.WriteLine("\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
            #endregion
        }
    }
}
