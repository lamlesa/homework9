using System;
using System.Threading;

namespace homework9
{
    internal abstract class BigRaces : Games
    {
        public abstract void PlayBeach(Teams team);
        public abstract void PlayFishing(Teams team);
        public void PlayMousetrap(Teams team)
        {
            Console.WriteLine("ИГРА 3: <<Мышеловка>>");
            Console.BackgroundColor = ConsoleColor.Red;
            Thread.Sleep(5000);
            Console.WriteLine("Попались !");
            Console.ResetColor();
        }
        public abstract void PlayPostmen(Teams team);
        public abstract void PlaySea(Teams team);
        public void PlaySlide(Teams team)
        {
            Console.WriteLine("ИГРА 6: <<Горка>>");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("   Г   ");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   О   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   Р   ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   К   ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   А   ");
            Console.ResetColor();
            Console.WriteLine("В этой игре побеждает дружба !!");
        }
        public void PlayUnderstood(Teams team)
        {
            Console.WriteLine("ИГРА 7: <<Понял>>");
            Console.WriteLine("Раз поняли, то молодцы !");
        }
    }
}