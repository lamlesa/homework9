using System;
using System.Threading;

namespace homework9
{
    internal class Teams : BigRaces
    {
        private string country;
        private string[] members = new string[15];
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string[] Members
        {
            get { return members; }
            set { members = value; }
        }
        public Teams(string country, params string[] members)
        {
            this.country = country;
            this.members = members;
        }
        public override void PlayBeach(Teams team)
        {
            Console.WriteLine("ИГРА 1: <<Пляж>>");
            Console.WriteLine("Суть игры: победит команда, собравшая большее количество ракушек на пляже.");
            bool flag = false;
            int a = 0;
            do
            {
                Console.Write("Какое количество ракушек вы собрали ? ");
                flag = int.TryParse(Console.ReadLine(), out a);
            } while (!flag);
            if (a > 1000)
            {
                throw new ArgumentException("На пляже не было такого количества ракушек, вы всех обманули, а значит вашу команду дисквалифицировали .");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Вы оказались благоразумны и упорны! Давайте поглядим на остальных!");
            }
            Random n = new Random();
            int k = 0, sum_y = 0, sum_t = 0;
            Console.WriteLine("ВАША КОМАНДА :");
            foreach (string member in team.Members)
            {
                k = n.Next(0, 1000);
                Console.WriteLine($"{member} : {k}");
                sum_y += k;
            }
            Console.WriteLine("КОМАНДА ПРОТИВНИКА :");
            foreach (string member in members)
            {
                k = n.Next(0, 1000);
                Console.WriteLine($"{member} : {k}");
                sum_t += k;
            }
            if (sum_y > sum_t)
            {
                Console.WriteLine($"ПОБЕЖДАЕТ КОМАНДА {team.Country} !");
            }
            else if (sum_y == sum_t)
            {
                Console.WriteLine("НИЧЬЯ .");
            }
            else
            {
                Console.WriteLine($"ПОБЕЖДАЕТ КОМАНДА {this.Country} !");
            }
        }
        public override void PlayFishing(Teams team)
        {
            Console.WriteLine("ИГРА 2: <<Рыбалка>>");
            Console.WriteLine("");
            bool win_y = false, win_t = false;
            Console.WriteLine("Суть игры: две команды угадывают рыбу по описанию, кто угадал того и приз !");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Итак описание: В кулинарии рыба ценится за вкусное мясо и небольшое количество костей.\nСамые мелкие особи по длине достигают 20 сантиметров,\nа крупные особи могут иметь размер более метра.\nПо весу может достичь 15 килограмм.");
            Console.ResetColor();
            Console.WriteLine("Ваш ответ ?\n1 - окунь\n2 - корюшка\n3 - селёдка");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                win_y = true;
                Console.WriteLine("Поздравляем ! Это действительно правильный ответ ! Давайте взглянем на ответ вашего соперника .");
            }
            else if (key == ConsoleKey.D2)
            {
                Console.WriteLine("К сожалению, вы ответили неверно ! Давайте взглянем на ответ вашего соперника .");
            }
            else if (key == ConsoleKey.D3)
            {
                Console.WriteLine("К сожалению, вы ответили неверно ! Давайте взглянем на ответ вашего соперника .");
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }
            Random n = new Random();
            int k = n.Next(1, 3);
            Console.WriteLine(k);
            if (k == 1)
            {
                win_t = true;
            }
            if (win_y && !win_t)
            {
                Console.WriteLine($"ПОБЕЖДАЕТ КОМАНДА {team.Country} !");
            }
            else if (win_y == win_t)
            {
                Console.WriteLine("НИЧЬЯ .");
            }
            else
            {
                Console.WriteLine($"ПОБЕЖДАЕТ КОМАНДА {this.Country} !");
            }
            Console.WriteLine("( победившая команда получает в качестве приза окуня. )");
        }
        public override void PlayPostmen(Teams team)
        {
            Console.WriteLine("ИГРА 4: <<Почтальоны>>");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i}) {team.Members[new Random().Next(0, team.Members.Length)]} относит письмо {members[new Random().Next(0, members.Length)]}");

            }
            Console.WriteLine("...Как у вас тут всё мило !");
        }
        public override void PlaySea(Teams team)
        {
            Console.WriteLine("ИГРА 5: <<Море>>");
            Console.WriteLine("Суть игры: любимая всеми игра <<Море волнуется раз>> Вам всего лишь нужно замереть в позе фигуры, обитающей в море !");
            bool win_y = false, win_t = false;
            Console.WriteLine("1... 2... 3... Вы замераете в форме ...\n1 - угря\n2 - русалки\n3 - осьминога");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                win_y = true;
                Console.WriteLine("Угри обитают в реках, а вот осьминоги и русалки вполне возможно ! Давайте взглянем на ответ вашего соперника .");
            }
            else if (key == ConsoleKey.D2)
            {
                Console.WriteLine("Мы ценим вашу фантазию, но, к сожалению, русалок не существует ! Давайте взглянем на ответ вашего соперника .");
            }
            else if (key == ConsoleKey.D3)
            {
                Console.WriteLine("Осьминог действительно обитатель моря ! Давайте взглянем на ответ вашего соперника .");
            }
            else
            {
                throw new ArgumentException("\nВы нажали не ту кнопку, вы дисквалифицированы .");
            }
            Random n = new Random();
            int k = n.Next(1, 3);
            Console.WriteLine(k);
            if (k == 3)
            {
                win_t = true;
            }
            if (win_y && !win_t)
            {
                Console.WriteLine($"ПОБЕЖДАЕТ КОМАНДА {team.Country} !");
            }
            else if (win_y == win_t)
            {
                Console.WriteLine("НИЧЬЯ .");
            }
            else
            {
                Console.WriteLine($"ПОБЕЖДАЕТ КОМАНДА {this.Country} !");
            }
        }
    }
}