using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /* Task 1.
        a) Преобразувайте 1234 в двоична и шестнадесетична бройна системи. 
        b) Преобразувайте 1100101b в десетична и шестнадесетична бройна системи. 
        c) Преобразувайте ABChex в десетично и двоична бройна системи
        */

        /// <summary>
        /// Функция за обръщане на текст
        /// </summary>
        /// <param name="str">Входен текст</param>
        /// <returns>Обърнат тест</returns>
        static string StringReverse(string str)
        {
            string result = string.Empty;
            for (var i = str.Length -1; i >= 0; i--)
            result += str[i];
            return result;
        }

        /// <summary>
        /// Конвертиране на десетично в двоично
        /// </summary>
        /// <param name="n">Десетично цяло число</param>
        /// <returns>Двоичен еквивалент на числото</returns>
        static string dec2bin(int n)
        {
            string result = string.Empty;
            while (n > 0)
            {
                result += (n % 2);
                n = n / 2;
            }
            return StringReverse(result);
        }

        /// <summary>
        /// Конвертиране на десетично в шестнадесетично
        /// </summary>
        /// <param name="n">Десетично цяло число</param>
        /// <returns>Шестнадесетичен еквивалент на числото</returns>
        static string dec2hex(int n)
        {
            string result = string.Empty;
            while (n > 0)
            {
                // ASCII: 0..9 = 48..57, A..F = 65..70
                int hex = (n % 16) + 48; // 0..9
                if (hex > 57) hex += 7; // A..F
                result += (char)hex;

                n = n / 16;
            }
            return StringReverse(result);
        }

        static void Main(string[] args)
        {
            // Конвертиране от десетична бройна система в двоична
            Console.WriteLine("1234(10) = {0}(2)", dec2bin(1234));

            // Конвертиране от десетична бройна система в шестнадесетична
            Console.WriteLine("1234(10) = {0}(16)", dec2hex(1234));
        }
    }
}
