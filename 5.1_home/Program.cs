using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        /// <summary>
        /// Метод разделения входной фразы на слова
        /// </summary>
        /// <param name="text">Строка, которую необходимо разделить</param>
        /// <returns>Массив слов из предложения</returns>
        public static string[] Reverse(string text)
        {
            char[] separators = new char[] { ' ', '.', ',', '-', '!', '?', '"', ':' };

            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return subs;
        }

        /// <summary>
        /// Метод изменения порядка слов
        /// </summary>
        /// <param name="text">Предложение, разобранное по словам</param>
        /// <returns>Слова в обратном порядке</returns>
        static string ReversWords(string text)
        {
            string[] FinalText = Reverse(text);
            Array.Reverse(FinalText);

            string NewString = "";
            for (int i = 0; i <= FinalText.Length - 1; i++)
            {
                NewString += FinalText[i] + " ";
            }

            return NewString;
        }

        /// <summary>
        /// Метод для вывода готовой строки
        /// </summary>
        /// <param name="ReadyText">Разделённая строка</param>
        static void Print(string ReadyText)
        {
            Console.Write(ReversWords(ReadyText));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string InputPhrase = Console.ReadLine();

            ReversWords(InputPhrase);
            Print(InputPhrase);

            Console.ReadKey();
        }
    }
}
