using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ввести с клавиатуры предложение. Предложение - слова, разделенные пробелом. Знаки препинания не использвать.");
            string aS = Console.ReadLine();
            string[] arrayS = aS.Split();
            int countWord = 0, maxWord = 0;// Начальные значения счетчиков массива и наиб. слова
            Console.WriteLine();
                for (int i = 0; i < arrayS.Length; i++)
                {
                    if (arrayS[i].Length > maxWord)
                    {
                    maxWord = arrayS[i].Length; // определение макс. кол-ва символов в массиве слов
                    countWord = i; //! счетчик индекса массива с наиб. длинной слова
                    }
                }
            Console.WriteLine(" Самое длинное слово в строке - {0} ", arrayS[countWord]);
            Console.ReadKey();
        }
    }
}
