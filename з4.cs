using System;

class Program
{
    static void Main(string[] args)
    {
        double x1,x2,y1,y2,S,P;
        Console.WriteLine("Введите кординату x1:");
        x1 = Convert.ToInt32(Console.ReadLine());//Ввод координаты x1
        Console.WriteLine("Введите кординату x2:");
        x2 = Convert.ToInt32(Console.ReadLine());//Ввод координаты x2
        Console.WriteLine("Введите кординату y1:");
        y1 = Convert.ToInt32(Console.ReadLine());//Ввод координаты y1
        Console.WriteLine("Введите кординату y2:");
        y2 = Convert.ToInt32(Console.ReadLine());//Ввод координаты y2
        double r = Math.Abs(x2 - x1);
        Console.WriteLine("Длина первой стороны прямоугольника:" + r);//Вывод первой стороны прямоугольника
        double l = Math.Abs(y2 - y1);
        Console.WriteLine("Длина второй стороны прямоугольника:" + l);//Вывод втоой стороны прямоугольника
         S = r * l; //Нахождение площади прямоугольника
         P = 2 * (r + l);//Нахождения периметра прямоугольника
        Console.WriteLine("Площадь прямоугольника:" + S);//Вывод площади прямоугольника
        Console.WriteLine("Периметр прямоугольника:" + P);//Вывод периметра прямоугольника
        Console.ReadLine();
    }

}
