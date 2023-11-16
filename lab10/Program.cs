using System;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("( после каждого ввода стоит нажимать Enter . )");
            {
                Console.WriteLine("Упражнение 10.1:");
                Console.WriteLine("( введённая строка не должна содержать НЕбуквенные и НЕцифровые символы . )");
                Console.Write("Введите строку, которую хотите зашифровать : ");
                string s = Console.ReadLine();
                ICipher a_cipher = new ACipher();
                ICipher b_cipher = new BCipher();
                Console.WriteLine($"Шифр А: {a_cipher.Encode(s)}");
                Console.WriteLine($"Расшифровка А: {a_cipher.Decode(a_cipher.Encode(s))}");
                Console.WriteLine($"Шифр В: {b_cipher.Encode(s)}");
                Console.WriteLine($"Расшифровка В: {b_cipher.Decode(b_cipher.Encode(s))}");
            }
            Console.WriteLine("");
            {
                Console.WriteLine("Домашнее задание 10.1:");

                InterfaceFigure point = new Point("green", true);
                InterfaceFigure circle = new Circle("red", false);
                InterfaceFigure rectangle = new Rectangle("blue", false);

                Console.WriteLine("( точка )");
                point.MoveHorizontally();
                point.ChangeColor();
                point.CalculateTheArea();
                point.PrintFields();

                Console.WriteLine("( круг )");
                circle.MoveVertically();
                circle.CalculateTheArea();
                circle.PrintFields();

                Console.WriteLine("( прямоугольник )");
                rectangle.CheckVisibility();
                rectangle.CalculateTheArea();
                rectangle.PrintFields();
            }
        }
    }
}