using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base2_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ввести с клавиатуры предложение. Предложение - слова, разделенные пробелом. Знаки препинания не использвать.");
            string myS = Console.ReadLine();
            string litleS = myS.Substring(0, myS.Length).ToLower();// Переводим предложение в строчный формат
            string noSpace = litleS.Replace(" ", string.Empty); //удаляем пробелы с предложения
            int lengthS = noSpace.Length; //вычисляем длинну предложения без пробелов
            char [] arrayS = noSpace.ToCharArray();
            bool flag = true;
            for (int i = 0;  i < lengthS/2; i++)
            {
                if (arrayS[i] !=arrayS[lengthS-i-1])
                {
                    flag = false;
                }

            }
            if (flag)
            {
                Console.WriteLine(" Введенная строка является палиндромом (без учёта пробелов и регистра! {0}", flag);
            }
            else
            {
                Console.WriteLine(" Введенная строка не является палиндромом (без учёта пробелов и регистра! {0}", flag);
            }
            Console.ReadKey();
        }
    }
}
