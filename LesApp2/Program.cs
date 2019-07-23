using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення числа
            Console.WriteLine("Введіть цілі числа:\n");
            Console.Write("\tA = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tB = ");
            int b = int.Parse(Console.ReadLine());

            // Довідка.
            // кон'юнкція - &&, побітове "і" - &
            // диз'юнкція - ||, побітове "або" - |
            // виключна диз'юнкція - ^ (циркумфлекс), побітове - ^
            // заперечення - !, побітове ~
            // побітове зміщення вправо >>, вліво <<

            Console.Write($"\n\tКон'юнкція: A && B - не виконується для цілих чисел;");
            Console.Write($"\n\tДиз'юнкція: A || B - не виконується для цілих чисел;");
            Console.Write($"\n\tПобітове \"and\": A & B = {a & b};");
            Console.Write($"\n\tПобітове \"or\": A | B = {a | b};");
            Console.Write($"\n\tПобітова виключна диз'юнкція \"xor\": A ^ B = {a ^ b};");
            Console.Write($"\n\tПобітове заперечення \"not\": ~A = {~a};");
            Console.Write($"\n\tПобітове заперечення \"not\": ~B = {~b};");
            Console.Write($"\n\tПобітове логічне зміщення вліво: A << 1 = {a << 1};");
            Console.Write($"\n\tПобітове логічне зміщення вліво: B << 1 = {b << 1};");
            Console.Write($"\n\tПобітове логічне зміщення вправо: A >> 1 = {a >> 1};");
            Console.Write($"\n\tПобітове логічне зміщення вправо: B >> 1 = {b >> 1};");

            #region Повторення
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
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
