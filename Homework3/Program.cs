using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Введите номер дня в году");
            uint n = Convert.ToUInt16(Console.ReadLine());
            if (n != 0 && n <= 31)
            {
                Console.WriteLine(n + " января");
            }
            else if (n > 31 && n <= 59)
            {
                Console.WriteLine(n - 31 + " февраля");
            }
            else if (n > 59 && n <= 90)
            {
                Console.WriteLine(n - 59 + " марта");
            }
            else if (n > 90 && n <= 120)
            {
                Console.WriteLine(n - 90 + " апреля");
            }
            else if (n > 120 && n <= 151)
            {
                Console.WriteLine(n - 120 + " мая");
            }
            else if (n > 151 && n <= 181)
            {
                Console.WriteLine(n - 151 + " июня");
            }
            else if (n > 181 && n <= 212)
            {
                Console.WriteLine(n - 181 + " июля");
            }
            else if (n > 212 && n <= 243)
            {
                Console.WriteLine(n - 212 + " августа");
            }
            else if (n > 243 && n <= 273)
            {
                Console.WriteLine(n - 243 + " сентября");
            }
            else if (n > 273 && n <= 304)
            {
                Console.WriteLine(n - 273 + " октября");
            }
            else if (n > 304 && n <= 334)
            {
                Console.WriteLine(n - 304 + " ноября");
            }
            else if (n > 334 && n <= 365)
            {
                Console.WriteLine(n - 334 + " декабря");
            }


            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите номер дня в году");
            n = Convert.ToUInt16(Console.ReadLine());
            try
            {
                if (n < 1 || n > 365)
                {
                    throw new ArgumentException("Неверно");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Введите номер от 1 до 365");
            }
            if (n != 0 && n <= 31)
            {
                Console.WriteLine(n + " января");
            }
            else if (n > 31 && n <= 59)
            {
                Console.WriteLine(n - 31 + " февраля");
            }
            else if (n > 59 && n <= 90)
            {
                Console.WriteLine(n - 59 + " марта");
            }
            else if (n > 90 && n <= 120)
            {
                Console.WriteLine(n - 90 + " апреля");
            }
            else if (n > 120 && n <= 151)
            {
                Console.WriteLine(n - 120 + " мая");
            }
            else if (n > 151 && n <= 181)
            {
                Console.WriteLine(n - 151 + " июня");
            }
            else if (n > 181 && n <= 212)
            {
                Console.WriteLine(n - 181 + " июля");
            }
            else if (n > 212 && n <= 243)
            {
                Console.WriteLine(n - 212 + " августа");
            }
            else if (n > 243 && n <= 273)
            {
                Console.WriteLine(n - 243 + " сентября");
            }
            else if (n > 273 && n <= 304)
            {
                Console.WriteLine(n - 273 + " октября");
            }
            else if (n > 304 && n <= 334)
            {
                Console.WriteLine(n - 304 + " ноября");
            }
            else if (n > 334 && n <= 365)
            {
                Console.WriteLine(n - 334 + " декабря");
            }


            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите номер дня в году");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите год");
            uint year = Convert.ToUInt16(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 && year % 400 == 0)
            {
                try
                {
                    if (n < 1 || n > 366)
                    {
                        throw new ArgumentException("Неверно");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Введите номер от 1 до 366");
                }
                if (n != 0 && n <= 31)
                {
                    Console.WriteLine(n + " января");
                }
                else if (n > 31 && n <= 60)
                {
                    Console.WriteLine(n - 31 + " февраля");
                }
                else if (n > 60 && n <= 91)
                {
                    Console.WriteLine(n - 60 + " марта");
                }
                else if (n > 91 && n <= 121)
                {
                    Console.WriteLine(n - 91 + " апреля");
                }
                else if (n > 121 && n <= 152)
                {
                    Console.WriteLine(n - 121 + " мая");
                }
                else if (n > 152 && n <= 182)
                {
                    Console.WriteLine(n - 152 + " июня");
                }
                else if (n > 182 && n <= 213)
                {
                    Console.WriteLine(n - 182 + " июля");
                }
                else if (n > 213 && n <= 244)
                {
                    Console.WriteLine(n - 213 + " августа");
                }
                else if (n > 244 && n <= 274)
                {
                    Console.WriteLine(n - 244 + " сентября");
                }
                else if (n > 274 && n <= 305)
                {
                    Console.WriteLine(n - 274 + " октября");
                }
                else if (n > 305 && n <= 335)
                {
                    Console.WriteLine(n - 305 + " ноября");
                }
                else if (n > 335 && n <= 366)
                {
                    Console.WriteLine(n - 335 + " декабря");
                }
            }
            else
            {
                try
                {
                    if (n < 1 || n > 365)
                    {
                        throw new ArgumentException("Неверно");
                    }
                }
                catch
                {
                    Console.WriteLine("Введите номер от 1 до 365");
                }
                if (n != 0 && n <= 31)
                {
                    Console.WriteLine(n + " января");
                }
                else if (n > 31 && n <= 59)
                {
                    Console.WriteLine(n - 31 + " февраля");
                }
                else if (n > 59 && n <= 90)
                {
                    Console.WriteLine(n - 59 + " марта");
                }
                else if (n > 90 && n <= 120)
                {
                    Console.WriteLine(n - 90 + " апреля");
                }
                else if (n > 120 && n <= 151)
                {
                    Console.WriteLine(n - 120 + " мая");
                }
                else if (n > 151 && n <= 181)
                {
                    Console.WriteLine(n - 151 + " июня");
                }
                else if (n > 181 && n <= 212)
                {
                    Console.WriteLine(n - 181 + " июля");
                }
                else if (n > 212 && n <= 243)
                {
                    Console.WriteLine(n - 212 + " августа");
                }
                else if (n > 243 && n <= 273)
                {
                    Console.WriteLine(n - 243 + " сентября");
                }
                else if (n > 273 && n <= 304)
                {
                    Console.WriteLine(n - 273 + " октября");
                }
                else if (n > 304 && n <= 334)
                {
                    Console.WriteLine(n - 304 + " ноября");
                }
                else if (n > 334 && n <= 365)
                {
                    Console.WriteLine(n - 334 + " декабря");
                }
            }
            Console.ReadKey();

        }
    }
}
