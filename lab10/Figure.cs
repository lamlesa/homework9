using System;

namespace lab10
{
    internal abstract class Figure : InterfaceFigure
    {
        private string color;
        private bool visibility;
        private int x;
        private int y;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool Visibility
        {
            get { return visibility; }
            set { visibility = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int MoveHorizontally()
        {
            int a = 0;
            bool flag = false;
            do
            {
                Console.Write("На сколько единиц подвинуть центр фигуры по горизонтали ? ");
                flag = int.TryParse(Console.ReadLine(), out a);
            } while (!flag);
            x += a;
            Console.WriteLine($"Центр фигуры был сдвинут на {a} единиц по горизонтали .");
            return x;
        }
        public int MoveVertically()
        {
            int b = 0;
            bool flag = false;
            do
            {
                Console.Write("На сколько единиц подвинуть центр фигуры по вертикали ? ");
                flag = int.TryParse(Console.ReadLine(), out b);
            } while (!flag);
            y += b;
            Console.WriteLine($"Центр фигуры был сдвинут на {b} единиц по вертикали .");
            return y;
        }
        public bool CheckVisibility()
        {
            if (visibility)
            {
                Console.WriteLine("Фигура видимая.");
                return true;
            }
            else
            {
                Console.WriteLine("Фигура невидимая.");
                return false;
            }
        }
        public string ChangeColor()
        {
            Console.WriteLine("На какой цвет вы хотите поменять ?\n1: красный\n2: зелёный\n3: голубой");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                color = "red";
                Console.WriteLine("\nЦвет фигуры поменялся на красный.");
            }
            else if (key == ConsoleKey.D2)
            {
                color = "green";
                Console.WriteLine("\nЦвет фигуры поменялся на зелёный.");
            }
            else if (key == ConsoleKey.D3)
            {
                color = "blue";
                Console.WriteLine("\nЦвет фигуры поменялся на голубой.");
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, цвет остался прежним.");
            }
            return color;
        }
        public abstract double CalculateTheArea();
        public void PrintFields()
        {
            Console.WriteLine($"Видимость : {visibility}\nЦвет: {color}\nПоложение центра: x: {x}, y: {y}");
        }
    }
}