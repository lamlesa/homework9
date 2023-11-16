using System;

namespace lab10
{
    internal class BCipher : ICipher
    {
        string alphabet_eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alphabet_rus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string Encode(string s)
        {
            string new_s = "";
            char new_symbol = ' ';
            foreach (char symbol in s)
            {
                if (Char.IsLetter(symbol))
                {
                    bool flag = false;
                    if (symbol == Char.ToUpper(symbol))
                    {
                        flag = true;
                    }
                    new_symbol = Char.ToUpper(symbol);
                    if (alphabet_eng.IndexOf(new_symbol) != -1)
                    {
                        if (flag)
                        {
                            new_s += alphabet_eng[Math.Abs(alphabet_eng.IndexOf(new_symbol) - 25)];
                        }
                        else
                        {
                            new_s += Char.ToLower(alphabet_eng[Math.Abs(alphabet_eng.IndexOf(new_symbol) - 25)]);
                        }
                    }
                    else
                    {
                        if (flag)
                        {
                            new_s += alphabet_rus[Math.Abs(alphabet_rus.IndexOf(new_symbol) - 32)];
                        }
                        else
                        {
                            new_s += Char.ToLower(alphabet_rus[Math.Abs(alphabet_rus.IndexOf(new_symbol) - 32)]);
                        }
                    }
                }
                else if (Char.IsDigit(symbol))
                {
                    switch (symbol)
                    {
                        case '0': new_s += '9'; break;
                        case '1': new_s += '8'; break;
                        case '2': new_s += '7'; break;
                        case '3': new_s += '6'; break;
                        case '4': new_s += '5'; break;
                        case '5': new_s += '4'; break;
                        case '6': new_s += '3'; break;
                        case '7': new_s += '2'; break;
                        case '8': new_s += '1'; break;
                        case '9': new_s += '0'; break;
                    }
                }
                else
                {
                    throw new ArgumentException("введённая строка не должна содержать НЕбуквенные и НЕцифровые символы .");
                }
            }
            return new_s;
        }

        public string Decode(string s)
        {
            string new_s = "";
            char new_symbol = ' ';
            foreach (char symbol in s)
            {
                if (Char.IsLetter(symbol))
                {
                    bool flag = false;
                    if (symbol == Char.ToUpper(symbol))
                    {
                        flag = true;
                    }
                    new_symbol = Char.ToUpper(symbol);
                    if (alphabet_eng.IndexOf(new_symbol) != -1)
                    {
                        if (flag)
                        {
                            new_s += alphabet_eng[Math.Abs(alphabet_eng.IndexOf(new_symbol) - 25)];
                        }
                        else
                        {
                            new_s += Char.ToLower(alphabet_eng[Math.Abs(alphabet_eng.IndexOf(new_symbol) - 25)]);
                        }
                    }
                    else
                    {
                        if (flag)
                        {
                            new_s += alphabet_rus[Math.Abs(alphabet_rus.IndexOf(new_symbol) - 32)];
                        }
                        else
                        {
                            new_s += Char.ToLower(alphabet_rus[Math.Abs(alphabet_rus.IndexOf(new_symbol) - 32)]);
                        }
                    }
                }
                else if (Char.IsDigit(symbol))
                {
                    switch (symbol)
                    {
                        case '0': new_s += '9'; break;
                        case '1': new_s += '8'; break;
                        case '2': new_s += '7'; break;
                        case '3': new_s += '6'; break;
                        case '4': new_s += '5'; break;
                        case '5': new_s += '4'; break;
                        case '6': new_s += '3'; break;
                        case '7': new_s += '2'; break;
                        case '8': new_s += '1'; break;
                        case '9': new_s += '0'; break;
                    }
                }
                else
                {
                    throw new ArgumentException("введённая строка не должна содержать НЕбуквенные и НЕцифровые символы .");
                }
            }
            return new_s;
        }
    }
}