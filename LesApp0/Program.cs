using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Завдання:
// Вивести всі знаки Unicode
// написавши код не більше 2 рядків
// Примітка. Не було вказано де саме відобразити, тому має місце бути 1 і 3 варіанти

namespace LesApp0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region Варіант 1. Показ символів Unicoded - в один рядок; Запуск вбудованої програми "Таблиця символів"
            //Process.Start("charmap.exe");
            #endregion

            #region Варіант 2. Показ символів Unicoded - в один рядок; Вивід символів Unicode із попередньо вбудованого текстового файлу в програму
            //Console.WriteLine(Properties.Resources.Unicode);
            #endregion

            #region Варіант 3. Показ символів Unicoded - в один або два = 1,5 рядка; Можливо, що файлу може не бути в корневій папці; Запуск через блокнот; Допомога https://metanit.com/sharp/tutorial/5.5.php
            //(new StreamWriter("Unicode.txt", false, Encoding.Unicode)).Write(Properties.Resources.Unicode);
            Process.Start("Unicode.txt");
            #endregion

            #region Варіант 4. Показ символів Unicoded - в один рядок; Допомога http://qaru.site/questions/376017/how-do-i-quicky-fill-an-array-with-a-specific-value
            //Console.WriteLine(Enumerable.Range(char.MinValue, char.MaxValue + 1).Select(t => (char)t).ToArray());
            #endregion

            #region Варіант 5. Показ символів Unicoded - в два рядки
            for (int i = char.MinValue; i <= char.MaxValue; i++)
                Console.Write((char)i);
            #endregion

            #region Варіант 6. Показ символів Unicoded - в два рядки
            //foreach (char i in Enumerable.Range(char.MinValue, char.MaxValue + 1).ToArray())
            //    Console.Write((char)i);
            #endregion

            // delay
            Console.ReadKey();
        }
    }
}
