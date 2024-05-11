using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    internal class Program
    {
        /// <summary>
        /// Метод разделения строки на слова
        /// </summary>
        /// <param name="text">Строка, которую необходимо разделить</param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            char[] separators = new char[] { ' ', '.', ',', '-', '!', '?', '"', ':' };

            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return subs;
        }

        /// <summary>
        /// Метод для вывода каждого слова в отдельной строке
        /// </summary>
        /// <param name="FinalText">Разделённая строка</param>
        static void Print(string subs)
        {

            foreach (var sub in SplitText(subs))
            {
                Console.WriteLine($"{sub}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            SplitText(sentence);
            Print(sentence);

            Console.ReadKey();
        }
    }
}
