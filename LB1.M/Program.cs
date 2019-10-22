using System;

namespace LB1.M
{
    class Program
    {
        static void Main(string[] args)
        {
           //Первое
            Console.WriteLine("Задание №1"); 
            try
            {                
                Console.WriteLine("Напишите дробное число");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Первое число после запятой= " + (int)((x - (int)x) * 10));
            }
            catch
            {
                Console.WriteLine("Error");
            }
            //Второе
            Console.WriteLine("Задание №2");
            try
            {
                Console.WriteLine("Введите число секунд"); 
                double Seconds = Convert.ToDouble(Console.ReadLine()),
                       Minutes = (Seconds / 60),
                       Hours = (Seconds / 3600);
                Console.WriteLine("Прошло "+Seconds+" секунд");
                Console.WriteLine("Прошло "+Minutes+" минут");
                Console.WriteLine("Прошло "+Hours+" часов");
            }
            catch
            {
                Console.WriteLine("Error");
            }
            //Третье
            Console.WriteLine("Задание №3");
            try
            {
                Console.WriteLine("Введите число часов от 0 до 11");
                double Hours1 = Convert.ToDouble(Console.ReadLine());
                if (Hours1 >= 0 &&
                    Hours1 <= 11)
                { }
                else
                {
                    Console.WriteLine("Введенное значение не соответствует условию");
                    Environment.Exit(0);
                }
                Console.WriteLine("Введите число минут от 0 до 59");
                double Minutes1 = Convert.ToDouble(Console.ReadLine());
                if (Minutes1 >= 0 &&
                    Minutes1 <= 59)
                { }
                else
                {
                    Console.WriteLine("Введенное значение не соответствует условию");
                    Environment.Exit(0);
                }
                Console.WriteLine("Введите число секунд от 0 до 59");
                double Seconds1 = Convert.ToDouble(Console.ReadLine());
                if (Seconds1 >= 0 &&
                    Seconds1 <= 59)
                { }
                else
                {
                    Console.WriteLine("Введенное значение не соответствует условию");
                    Environment.Exit(0);
                }
                double  aps = 90 / 10800.0,//находим угол в 1 секунде
                        sec = Seconds1 + (Minutes1 * 60) + (Hours1 *3600),
                        Alpfa = sec * aps;//в 1 секунде 0.008(3) градуса
                Console.WriteLine("Угол = " + Math.Round(Alpfa,2));
            }
            catch 
            { 
                Console.WriteLine("Error");
            }
            //Четвёртое
            Console.WriteLine("Задание №4");
            try
            {
                Console.WriteLine("Напишите первую переменную");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Напишите вторую переменную");
                int y1 = int.Parse(Console.ReadLine());
                x1 = y1 + x1;
                y1 = x1 - y1;
                x1 = x1 - y1;
                Console.WriteLine("Теперь первая переменная "+x1);
                Console.WriteLine("Теперь вторая переменная "+y1);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            //Пятое
            Console.WriteLine("Задание №5");
            try
            {
                Console.WriteLine("Введите длинну первого катета в см");
                float a_t = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите длинну второго катета в см");
                float b_t = float.Parse(Console.ReadLine()),
                       S = (a_t * b_t) / 2;     //Синусом пренебрегаем, т.к. он равен 1
                Console.WriteLine("S = " + S + " см");
                double P = Math.Sqrt((Math.Pow(a_t,2) + Math.Pow(b_t,2))) + a_t + b_t;
                Console.WriteLine("P = " + P + " см");
            }
            catch
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Задание №6");
            try
            {
                Console.WriteLine("Введите целое четырёхзначное число");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a >= 1000 &&
                    a <= 9999)
                { }                    
                    else
                    {
                        Console.WriteLine("Введено неверное число");
                        Environment.Exit(0);
                    }               
                int x = a / 1000;
                int y = a / 100 % 10;
                int z = a / 10 % 10;
                int t = a % 10;
                int s1 = x * y * z * t;
                Console.WriteLine("Результат" + s1);
            }
            catch
            {
                Console.WriteLine("Error");
            }
               //Седьмое
                Console.WriteLine("Задание №7");
                try
                {                
                int reversed = 0;
                Console.WriteLine("Введите трехзначное число");
                int R = Convert.ToInt32(Console.ReadLine());
                if (R >= 100 &&
                    R <= 999)
                {}
                else
                {
                    Console.WriteLine("Введено неверное значение");
                    Environment.Exit(0);
                }
                while (R > 0)
                {
                    reversed *= 10;
                    reversed += R % 10;
                    R /= 10;
                }
                Console.WriteLine("Результат = " + reversed);
                }
                catch
                {
                Console.WriteLine("Error");
                }
            //Восьмое
            Console.WriteLine("Задание №8");
            try
            {
                Console.WriteLine("Введите  значение х");
                double x_s = Convert.ToInt32(Console.ReadLine());
                double Ansver = x_s * (x_s * (x_s * (3 * x_s - 5) + 2) - 1) + 7;
                Console.WriteLine("Ответ: x = " + Ansver);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            //Девятое
            Console.WriteLine("Задание №9");
            try
            {
                Console.WriteLine("Введите целочисленный коэффициент а1, а2, а3.");
                double a1 = int.Parse(Console.ReadLine()),
                       a2 = int.Parse(Console.ReadLine()),
                       a3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите целочисленный коэффициент b1, b2, b3.");
                double b1 = int.Parse(Console.ReadLine()),
                       b2 = int.Parse(Console.ReadLine()),
                       b3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите целочисленный коэффициент c1, c2, c3.");
                double c1 = int.Parse(Console.ReadLine()),
                       c2 = int.Parse(Console.ReadLine()),
                       c3 = int.Parse(Console.ReadLine());
                double D = ((a1 * b2 * c3) + (a2 * b3 * c1) + (b1 * c2 * a3)) - ((c1 * b2 * a3) + (c2 * b3 * a1) + (a2 * b1 * c3)); //Определитель матрицы
                if (D == 0)
                {
                    Console.WriteLine("Система не имеет решения");
                    Environment.Exit(0);
                }
                Console.WriteLine("Введите ответы на каждое уравнение(d1, d2, d3)");
                double  d1 = Convert.ToInt32(Console.ReadLine()),
                        d2 = Convert.ToInt32(Console.ReadLine()),
                        d3 = Convert.ToInt32(Console.ReadLine());
                double x_sys, y_sys, z_sys, x_D, y_D, z_D;
                x_D = ((d1 * b2 * c3) + (d2 * b3 * c1) + (b1 * c2 * d3)) - ((c1 * b2 * d3) + (b3 * c2 * d1) + (d2 * b1 * c3)); //По методу Крамера
                y_D = ((a1 * d2 * c3) + (a2 * d3 * c1) + (d1 * c2 * a3)) - ((c1 * d2 * a3) + (c2 * d3 * a1) + (a2 * d1 * c3)); 
                z_D = ((a1 * b2 * d3) + (a2 * b3 * d1) + (b1 * d2 * a3)) - ((d1 * b2 * a3) + (d2 * b3 * a1) + (a2 * b1 * d3)); 
                x_sys = x_D / D;
                y_sys = y_D / D;
                z_sys = z_D / D;
                Console.WriteLine("х = " + x_sys);
                Console.WriteLine("y = " + y_sys);
                Console.WriteLine("z = " + z_sys);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
