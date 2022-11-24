//*****************************************************************************
//*Практическая работа № 12                                                   *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                       *
//* Задание: изучение методов создания собственных функций с помощью языка С#.*
//*****************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PR_12
{
    class Program
    {
        static string Reverse(string s1)//метод, принимающий аргумент string
        {
            char[] chars = s1.ToCharArray();
            Array.Reverse(chars);
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(chars[i]);
            }
            //Console.WriteLine(chars);
            return new string(chars);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Практическая раабота №12");
            Console.WriteLine("Здравствуйте");
            try
            {
                //Ввод данных
                string s1=null;
                Console.Write("Введите слово:");
                s1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(s1)) throw new Exception("Введена пустая строка");            
                else
                {
                    Console.WriteLine("Перевернутое значение:");
                    //вызов функции
                    string reverse = Reverse(s1);//вызов функции с указанием аргументов
                    Console.WriteLine("\nИсходное значение:");
                    Console.WriteLine(s1);
                }               
                                         
            }
            catch(FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка :" + fe.Message);
            }

            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка :" + e.Message);
            }
            Console.ReadKey();

        }
    }
}

