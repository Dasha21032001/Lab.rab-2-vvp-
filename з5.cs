using System;

    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, r, l, k, p, S, P;
            Console.Write("Введите x1:");
            x1 = Convert.ToInt32(Console.ReadLine());// Вывод x1
            Console.Write("Введите x2:");
            x2 = Convert.ToInt32(Console.ReadLine());//Вывод x2
            Console.Write("Введите x1:");
            x3 = Convert.ToInt32(Console.ReadLine());// Вывод x3
            Console.Write("Введите y1:");
            y1 = Convert.ToInt32(Console.ReadLine());//Вывод y1
            Console.Write("Введите y2:");
            y2 = Convert.ToInt32(Console.ReadLine());//Вывод y2
            Console.Write("Введите y2:");
            y3 = Convert.ToInt32(Console.ReadLine());//Вывод y3
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Первая сторона треугольника:" + r);//Вывод первой стороны треугольника
            l = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            Console.WriteLine("Вторая сторона треугольника:" + l);//Вывод второй стороны треугольника
            k = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            Console.WriteLine("Третья сторона треугольника:" + k);//Вывод третий стороны треугольника
            p = (r + l + k) / 2;//Полупериметр треугольника
            S = Math.Sqrt(p * (p - r) * (p - l) * (p - k));//Площадь треугольника
            Console.WriteLine("Площадь треугольника:" + S);//Вывод площади треугольника
            P = r + l + k;//Периметр треугольника
            Console.WriteLine("Периметр треугольника:" + P);//Вывод периметра треугольника
            Console.ReadLine();
            
        }
    }
