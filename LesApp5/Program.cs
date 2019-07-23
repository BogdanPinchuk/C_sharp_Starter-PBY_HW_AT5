using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp5
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Рандомні числа? так як немає умови їх введення
            Random rnd = new Random();
            int a = rnd.Next(short.MinValue, short.MaxValue),
                b = rnd.Next(short.MinValue, short.MaxValue),
                c = rnd.Next(short.MinValue, short.MaxValue);

            // Введення чисел
            Console.WriteLine("Цілі числа:\n");
            Console.Write($"\tA = {a:N0}\n");
            Console.Write($"\tB = {b:N0}\n");
            Console.Write($"\tC = {c:N0}\n");

            if ((a % 5 == 0) ||
                (b % 5 == 0) ||
                (c % 5 == 0))
            {
                // знаходження суми чисел які кратні 5
                int sum = ((a % 5 == 0) ? a : 0) +
                    ((b % 5 == 0) ? b : 0) +
                    ((c % 5 == 0) ? c : 0);

                Console.WriteLine($"\nСума чисел кратних 5: {sum:N0};");
                
                // Перевірка чи всі числа кратні 5
                if ((a % 5 == 0) &&
                    (b % 5 == 0) &&
                    (c % 5 == 0))
                {
                    Console.WriteLine("\nВсі числа кратні 5.");
                }
            }
            else
            {
                Console.WriteLine("\nError.");
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
