using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Примітка. В умовах вказано більше 100 і менше 50
            // згідно цього формулювання необхідно записати:
            // x є (-∞, 50) U (100, +∞) або (x < 50) || (100 > x)
            // але згыдно зауважень на уроці, ці числа необхідно
            // включати в діапазон: і записати (x <= 50) || (100 => x)
            // x є (-∞, 50] U [100, +∞)

            // Введення чисел
            Console.WriteLine("Введіть цілі числа:\n");
            Console.Write("\tA = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tB = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\tC = ");
            int c = int.Parse(Console.ReadLine());

            // Розрахунок:

            // сума чисел
            int sum = a + b + c;

            // виконання умов
            if (sum <= 50 || 100 <= sum)
            {
                Console.WriteLine("\nПоза діапазоном!");
            }
            else if (51 <= sum && sum <= 99)
            {
                // перевірка парних чисел
                if (a % 2 == 0)
                {
                    Console.WriteLine($"\nПарне число наявне: A = {a};");
                }

                if (b % 2 == 0)
                {
                    Console.WriteLine($"\nПарне число наявне: B = {b};");
                }

                if (c % 2 == 0)
                {
                    Console.WriteLine($"\nПарне число наявне: C = {c};");
                }

                if (a % 2 == 1 && b % 2 == 1 && c % 2 == 1)
                {
                    Console.WriteLine($"\nПарні числа відсутні.");
                }
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
