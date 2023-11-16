using System;

namespace lab10
{
    internal class Circle : Point
    {
        public Circle(string color, bool visibility) 
        {
            Color = color;
            Visibility = visibility;
            X = 0;
            Y = 0;
        }
        public override double CalculateTheArea()
        {
            double a = 0, S = 0;
            bool flag = false;
            do
            {
                Console.Write("Чему равен радиус круга ? ");
                flag = double.TryParse(Console.ReadLine(), out a);
            } while (!flag);
            if (a <= 0)
            {
                throw new ArgumentException("Введённое число не является радиусом круга (<= 0) .");
            }
            else
            {
                S = a * a * Math.PI;
                Console.WriteLine($"Площадь круга: {S}");
            }
            return S;
        }
    }
}