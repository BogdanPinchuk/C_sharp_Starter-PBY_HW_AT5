using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp4
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Примітка. Неуточнення діапазону в умові 
            // із включенням числа чи не включенням 
            // збиває з правильного рішення, так як невідомо
            // парвильно діапазону. І реалізація може
            // відрізнятися від задуманого автором.
            // В умовы сказано більше 10, а отже згідно правил
            // це записується як "x > 10"

            // Введення чисел
            Console.WriteLine("Введіть цілі числа:\n");
            Console.Write("\tA = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tB = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\tC = ");
            int c = int.Parse(Console.ReadLine());

            // Виконання умов
            if ((a % 2 == 0) && (b % 2 == 0) && (c > 10))
            {
                Console.WriteLine("\nПерші числа парні.");
            }
            else if (c % 2 == 1)
            {
                Console.WriteLine("\n3-тє число непарне.");
            }
            else if (a % 2 == 0 && c % 2 == 0)
            {
                Console.WriteLine("\nНепідходящі числа.");
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
