using System;

namespace homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] members_1 = { "Квета", "Денегатия", "Фафуил", "Варипсаф", "Ия", "Герасим", "Авдей", "Вавила", "Гурьян", "Елисей", "Галатея", "Клавдия", "Орентий", "Иван", "Штирлиц" };
            string[] members_2 = { "Жоржетта", "Ирен", "Людвин", "Марселин", "Оливье", "Наполеон", "Огюст", "Серж", "Ойя", "Фрэнсис", "Хоаким", "Эмелин", "Флавиен", "Тьерри", "Штирлиц" };
            string[] members_3 = { "Вен", "Жу", "Ксиаожи", "Дзен", "Джу", "Лицзянь", "Ланьюн", "Ксяотонг", "Мин", "Ню", "Чонгкун", "Хуа", "Фу", "Сю", "Штирлиц" };
            string[] members_4 = { "Айша", "Гаухар", "Бибигуль", "Жамал", "Зайыр", "Сахи", "Зейнеп", "Мухтар", "Кобжан", "Фатима", "Сайын", "Хафиз", "Ыдырас", "Ыбырай", "Штирлиц" };
            Teams team_1 = new Teams("Russia", members_1);
            Teams team_2 = new Teams("France", members_2);
            Teams team_3 = new Teams("China", members_3);
            Teams team_4 = new Teams("Kazakhstan", members_4);

            Console.WriteLine("Давайте начинать наше шоу !");

            Console.WriteLine("Команды участвуют в играх следующем порядке: 1) Россия\n2) Франция\n3) Китай\n4) Казахстан\n5) Россия\n6) Франция\n7) Казахстан");
            Console.WriteLine("Вам предстоит выбирать соперников для каждой из команд в каждом раунде !");
            Console.WriteLine("На время игры вы помогаете участникам команды, которую выбрали !");
            Console.WriteLine("Выберите соперников для 1-ой команды:\n2 - Франция\n3 - Китай\n4 - Казахстан");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.D2)
            {
                team_1.PlayBeach(team_2);
            }
            else if (key == ConsoleKey.D3)
            {
                team_1.PlayBeach(team_3);
            }
            else if (key == ConsoleKey.D4)
            {
                team_1.PlayBeach(team_4);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }

            Console.WriteLine("Выберите соперников для 2-ой команды:\n1 - Россия\n3 - Китай\n4 - Казахстан");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                team_2.PlayFishing(team_1);
            }
            else if (key == ConsoleKey.D3)
            {
                team_2.PlayFishing(team_3);
            }
            else if (key == ConsoleKey.D4)
            {
                team_2.PlayFishing(team_4);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }

            Console.WriteLine("Выберите соперников для 3-ей команды:\n1 - Россия\n2 - Франция\n4 - Казахстан");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                team_3.PlayMousetrap(team_1);
            }
            else if (key == ConsoleKey.D2)
            {
                team_3.PlayMousetrap(team_2);
            }
            else if (key == ConsoleKey.D4)
            {
                team_3.PlayMousetrap(team_4);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }

            Console.WriteLine("Выберите соперников для 4-ой команды:\n1 - Россия\n3 - Франция\n3 - Китай");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                team_4.PlayPostmen(team_1);
            }
            else if (key == ConsoleKey.D2)
            {
                team_4.PlayPostmen(team_2);
            }
            else if (key == ConsoleKey.D3)
            {
                team_4.PlayPostmen(team_3);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }

            Console.WriteLine("Мы пошли по второму кругу !");

            Console.WriteLine("Выберите соперников для 1-ой команды:\n2 - Франция\n3 - Китай\n4 - Казахстан");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D2)
            {
                team_1.PlaySea(team_2);
            }
            else if (key == ConsoleKey.D3)
            {
                team_1.PlaySea(team_3);
            }
            else if (key == ConsoleKey.D4)
            {
                team_1.PlaySea(team_4);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }

            Console.WriteLine("Выберите соперников для 2-ой команды:\n1 - Россия\n3 - Китай\n4 - Казахстан");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                team_2.PlaySlide(team_1);
            }
            else if (key == ConsoleKey.D3)
            {
                team_2.PlaySlide(team_3);
            }
            else if (key == ConsoleKey.D4)
            {
                team_2.PlaySlide(team_4);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }

            Console.WriteLine("Выберите соперников для 4-ой команды:\n1 - Россия\n3 - Франция\n3 - Китай");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                team_4.PlayUnderstood(team_1);
            }
            else if (key == ConsoleKey.D2)
            {
                team_4.PlayUnderstood(team_2);
            }
            else if (key == ConsoleKey.D3)
            {
                team_4.PlayUnderstood(team_3);
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }
            Console.WriteLine("ИГРА ОКОНЧЕНА .\nНадеемся, вам было весело =))))");
        }
    }
}