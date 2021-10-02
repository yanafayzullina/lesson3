using HandlebarsDotNet.StringUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Functions;

namespace Homeworkfile3
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1");
            Console.WriteLine("Введите вещественное число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(number));


            Console.WriteLine("1.2");
            Console.WriteLine("Введите первое число");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(number) > Math.Abs(number2))
            {
                Console.WriteLine((double)(number / 2));
            }


            Console.WriteLine("1.3");
            Console.WriteLine("Введите название животного");
            string animal = Console.ReadLine();
            if (animal == "аллигатор")
            {
                Console.WriteLine("small");
            }
            else
            {
                Console.WriteLine("wide");
            }


            Console.WriteLine("1.4");
            Console.WriteLine("Введите строку");
            try
            {
                string input = Console.ReadLine().ToLower();
                if (input == "jabroni")
                {
                    Console.WriteLine("Patron Tequila");
                }
                else if (input == "school counselor")
                {
                    Console.WriteLine("Anything with Alcohol");
                }
                else if (input == "programmer")
                {
                    Console.WriteLine("Hipster Craft Beer");
                }
                else if (input == "bike gang member")
                {
                    Console.WriteLine("Moonshine");
                }
                else if (input == "politician")
                {
                    Console.WriteLine("Your tax dollars");
                }
                else if (input == "rapper")
                {
                    Console.WriteLine("Cristal");
                }
                else
                    throw new Exception("Всё остальное");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beer");
            }


            Console.WriteLine("1.5");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine().ToLower();
            if (str.Contains("english"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            Console.WriteLine("2.1");
            Console.WriteLine(1 + (1 + 1 / 3) * (1 + 1 / 3 * 1 / 3) * (1 / 3 + 1 / 3 * 1 / 3 * 1 / 3 * 1 / 3 * 1 / 3));


            Console.WriteLine("2.3");
            Console.WriteLine("Введите сумму количества осадков за январь");
            uint precip1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму количества осадков за март");
            uint precip2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Среднедневное количество осадков за январь: " + precip1 / 31);
            Console.WriteLine("Среднедневное количество осадков за март: " + precip2 / 31);


            Console.WriteLine("3.2");
            Console.WriteLine("Введите n");
            uint n = Convert.ToUInt32(Console.ReadLine());
            for (uint k = 1; k * k < n; k++)
                Console.WriteLine(k * k);


            Console.WriteLine(3.3);
            int a = 100;
            while (n > 79)
                Console.WriteLine(n--);
            Console.WriteLine("-- ИЛИ --");
            a = 100;
            do
                Console.WriteLine(n--);
            while (a > 79);


            Console.WriteLine(3.4);
            int num = 5000;
            while (num % 39 != 0)
            {
                num--;
            }
            Console.WriteLine("Максимальное число: " + num);


            Console.WriteLine(3.5);
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("a: 5 ");
                }
            }
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("б: 1 ");
                }
            }
            Console.ReadKey();
        }
    }
}
