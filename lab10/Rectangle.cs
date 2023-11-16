using System;

namespace lab10
{
    internal class Rectangle : Point
    {
        public Rectangle(string color, bool visibility)
        {
            Color = color;
            Visibility = visibility;
            X = 0;
            Y = 0;
        }
        public override double CalculateTheArea()
        {
            double a = 0, b = 0, S = 0;
            bool flag = false;
            do
            {
                Console.Write("Чему равна длина прямоугольника ? ");
                flag = double.TryParse(Console.ReadLine(), out a);
            } while (!flag);
            
            do
            {
                Console.Write("Чему равна ширина прямоугольника ? ");
                flag = double.TryParse(Console.ReadLine(), out b);
            } while (!flag);

            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Стороны прямоугольника не могут быть отрицательными или 0 .");
            }
            else
            {
                S = a * b;
                Console.WriteLine($"Площадь прямоугольника: {S}");
            }
            return S;
        }
    }
}