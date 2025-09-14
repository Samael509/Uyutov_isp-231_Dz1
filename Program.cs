using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyutov_pavel_isp_231_Dz1
{
    class Program
    {
        static void Main(string[] args)
        {
                // Задание 1
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"сумма: {a + b}");
                Console.WriteLine($"разность: {a - b}");
                Console.WriteLine($"произведение: {a * b}");
                double dd;
                dd = (double)a / b;
                Console.WriteLine($"Частность: {dd}");

                // Задание 2
                Console.WriteLine("Ваше имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Ваш возраст: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Твой любимый язык программировния: ");
                string language = Console.ReadLine();

                string check;
                if (age % 10 == 1 && age % 100 != 11)
                {
                    check = "год";
                }
                else if ((age % 10 >= 2 && age % 10 <= 4) && (age % 100 < 10 || age % 100 >= 20))
                {
                    check = "года";
                }
                else
                {
                    check = "лет";
                }

                Console.WriteLine($"Привет, {name}");
                Console.WriteLine($"Тебе {age} {check}");
                Console.WriteLine($"Твой любимый язык программирования - {language}");

                // Задание 3 not ready
                Console.WriteLine("Введите a, b, c");
                int a1 = int.Parse(Console.ReadLine());
                int b1 = int.Parse(Console.ReadLine());
                int c1 = int.Parse(Console.ReadLine());
                int x = 5;

                int f = a1 * x * x + b1 * x + c1;
                Console.WriteLine($"Значение f(5): {f}");
                
    

                // Задание 4
                Console.WriteLine("Ваше имя: ");
                string name1 = Console.ReadLine();
                Console.WriteLine("Ваш возраст: ");
                int age1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш город: ");
                string city = Console.ReadLine();
                Console.WriteLine("Ваше любимое число: ");
                int digit = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите температуру в цельсиях: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double f1 = c * 9 / 5 + 32;

                string check1;
                if (age1 % 10 == 1 && age1 % 100 != 11)
                {
                    check1 = "год";
                }
                else if ((age1 % 10 >= 2 && age1 % 10 <= 4) && (age1 % 100 < 10 || age1 % 100 >= 20))
                {
                    check1 = "года";
                }
                else
                {
                    check1 = "лет";
                }

                Console.WriteLine("=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
                Console.WriteLine($"Привет, {name1}!\nТебе {age1} {check1}\nВ следующем году тебе будет {age1 + 1}");
                Console.WriteLine();
                Console.WriteLine($"Ты живёшь в городе {city}\nТвоё любимое число: {digit} (в квадрате: {Math.Pow(digit, 2)})");
                Console.WriteLine();
                Console.WriteLine($"Температура за окном:\n- В цельсиях: {c}\n- в фаренгейтах: {f}");
                Console.WriteLine("=== КОНЕЦ ПРОФИЛЯ ===");

        }
    }
    
}
