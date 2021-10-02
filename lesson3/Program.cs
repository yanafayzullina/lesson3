using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork3
{
    public enum DayOfWeek : byte
    {
        Monday = 1,
        Thuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }


    public enum Cards : byte
    {
        six = 6,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int number = new Random().Next(100, 1000), num, revnum = 0, rem;
            num = number;
            while (number > 0)
            {
                rem = number % 10;
                revnum = revnum * 10 + rem;
                number = number / 10;
            }
            if (revnum == num)
            {
                Console.WriteLine(num + " является палиндромом");
            }
            else
            {
                Console.WriteLine(num + " не является палиндромом");
            }


            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину форточки");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите ширину форточки");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Васи");
            int d = Convert.ToInt16(Console.ReadLine());
            if (d < a + 2 && d < b + 2)
            {
                Console.WriteLine("Голова пролезет в форточку");
            }
            else
            {
                Console.WriteLine("Голова не пролезет в форточку");
            }


            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите номер дня недели");
            byte daynum = Convert.ToByte(Console.ReadLine());
            if (daynum > 0 && daynum < 8)
            {
                DayOfWeek day;
                day = (DayOfWeek)daynum;
                Console.WriteLine(day);
            }
            else
            {
                Console.WriteLine("Ошибка. Введите номер от 1 до 7");
            }


            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите порядковый номер карты");
            byte cardnum = Convert.ToByte(Console.ReadLine());
            try
            {
                if (cardnum > 5 && cardnum < 15)
                {
                    Cards card;
                    card = (Cards)cardnum;
                    Console.WriteLine(card);
                }
                else
                {
                    throw new ArgumentException("Неверно");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Введите номер от 6 до 14");
            }


            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите значение высоты в км от 1 до 10");
            uint r = 6350;
            byte h = Convert.ToByte(Console.ReadLine());
            if (h > 0 && h < 11)
            {
                double s = Math.Sqrt(h * (2 * r + h));
            }


            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите число от 1 до 10");
            byte n = Convert.ToByte(Console.ReadLine());
            if (n > 0 && n < 11)
            {
                for (byte i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n + " x " + i + " = " + (n * i));
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Ваше число не входит в диапазон (1; 10)");
            }
        } 
}