using System;



class Program
{
    static void Main(string[] args)
    {
        double A, B, C, r, l;
        Console.WriteLine("Введите точку А:");
        A = Convert.ToInt32(Console.ReadLine());//Ввод точки А
        Console.WriteLine("Введите точку В:");
        B = Convert.ToInt32(Console.ReadLine());//Ввод точки В
        Console.WriteLine("Введите точку C:");
        C = Convert.ToInt32(Console.ReadLine());//Ввод точки C
        r = Math.Abs(A - C);
        Console.WriteLine("Длина АС:" + r);//Вывод длины отрезка АС
        l = Math.Abs (B - C);
        Console.WriteLine("Длина BС:" + l);//Вывод длины отрезка BС
        double S = r + l;
        Console.WriteLine("Сумма отрезков АС И ВС:" + S);//Вывод суммы отрезков АС и ВС
        Console.ReadLine();
    }

}
