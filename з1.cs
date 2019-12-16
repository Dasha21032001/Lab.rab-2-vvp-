using System;


namespace лаб.раб__2_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, r;
            Console.Write("Введите x1:");
            x1 = Convert.ToInt32(Console.ReadLine());// Вывод x1
            Console.Write("Введите x2:");
            x2 = Convert.ToInt32(Console.ReadLine());//Вывод x2
            Console.Write("Введите y1:");
            y1 = Convert.ToInt32(Console.ReadLine());//Вывод y1
            Console.Write("Введите y2:");
            y2 = Convert.ToInt32(Console.ReadLine());//Вывод y2

            {
                r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("r:" + r);//Вывод расстояния между двумя точками
                Console.ReadLine();
            }
    }
}
}
