using System;

namespace labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а\n");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b\n");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число c\n");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Число а :{a}\nЧисло b:{b}\nЧисло c:{c}");


            double d0 = (Math.Pow((a+3), c+1)-10)/(a-b);
            Console.WriteLine(d0);
            double d1 = b/(15*Math.Abs(a+b));
            Console.WriteLine(d1);
            double d2 = Math.Sqrt(Math.Abs(Math.Cos(b)/Math.Sin(a)+8));
            Console.WriteLine(d2);

            double d = d0 + d1 + d2;
            Console.Write(d);
        }
    }
}
