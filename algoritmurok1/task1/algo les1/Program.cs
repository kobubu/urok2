using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace algo_les1
{
    class Program
    {

        //Написать консольное приложение.
        //    Алгоритм реализовать отдельно в функции согласно блок-схеме.
        //    Написать проверочный код в main функции.
        //    Код выложить на GitHub.

        public static void Function()
        {
            int d = 0;
            int i = 2;
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out int n);
            if (result != true)
            {
                Console.WriteLine("Преобразование завершилось неудачно\n" +
                                  "Введите другое число");

            }
            
       

            while (i < n)
            {
                if (n % i != 0)
                {
                    i++;
                }
                else
                {
                    d++;
                    i++;
                }   
            }



            if (d == 0)
            {
                Console.WriteLine("Вы ввели простое число");
                
            }
            else
            {
                Console.WriteLine("Число, что вы ввели, не является простым");
            }
            
        }

 
        static void Main(string[] args)
        {
            Function();
        }
    }
}
