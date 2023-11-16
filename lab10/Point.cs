using System;

namespace lab10
{
    internal class Point : Figure
    {
        public Point() { }
        public Point(string color, bool visibility)
        {
            Color = color;
            Visibility = visibility;
            X = 0;
            Y = 0;
        }
        public override double CalculateTheArea()
        {
            Console.WriteLine("У точки нет площади.");
            return 0;
        }
    }
}