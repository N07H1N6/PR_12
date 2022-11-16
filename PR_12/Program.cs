//*****************************************************************************
//*Практическая работа № 12                                                   *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                       *
//* Задание: изучение методов создания собственных функций с помощью языка С#.*
//*****************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_12
{
    class Program
    {
        static string Reverse(string s1)//метод, принимающийаргумент string
        {
            char[] chars = s1.ToCharArray();
            Array.Reverse(chars);
            for(int i= 0;i<s1.Length;i++)
            {
                Console.Write(chars[i]);
            }
            //Console.WriteLine(chars);
            return new string (chars);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая раабота №12");
            Console.WriteLine("Здравствуйте");
            try
            {
                //Ввод данных
                string s1;
                Console.Write("Введите слово:");
                s1 = Console.ReadLine();
                Console.WriteLine("Перевернутое значение:");
                //вызов функции
                string reverse = Reverse(s1);//вызов функции с указанием аргументов
                Console.WriteLine("\nИсходное значение:");
                Console.WriteLine(s1);

            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка ввода данных:" + e.Message);
            }
            Console.ReadKey();

        }
    }
}


    


