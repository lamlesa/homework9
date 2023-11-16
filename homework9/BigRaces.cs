using System;
using System.Threading;

namespace homework9
{
    internal abstract class BigRaces : Games
    {
        public abstract void PlayBeach(Teams team);
        public abstract void PlayFishing(Teams team);
        public void PlayMousetrap()
        {
            Console.WriteLine("\nИГРА 3: <<Мышеловка>>");
            Console.BackgroundColor = ConsoleColor.Red;
            Thread.Sleep(5000);
            Console.WriteLine("Попались !");
            Console.ResetColor();
        }
        public abstract void PlayPostmen(Teams team);
        public abstract void PlaySea(Teams team);
        public void PlaySlide()
        {
            Console.WriteLine("\nИГРА 6: <<Горка>>");
            string s = "ГОРКА"; 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{s[0]}");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{s[1], 2}");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{s[2], 4}");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{s[3], 6}");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{s[4], 8}");
            Console.ResetColor();
            Console.WriteLine("В этой игре побеждает дружба !!");
        }
        public abstract void PlayLostInTranslation(Teams team);
    }
}