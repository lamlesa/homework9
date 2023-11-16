using System;

namespace lab10
{
    internal class ACipher : ICipher
    {
        string alphabet_eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string alphabet_rus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string Encode(string s)
        {
            string new_s = ""; 
            foreach(char symbol in s)
            {
                if (alphabet_eng.IndexOf(symbol) != -1)
                {
                    switch (symbol)
                    {
                        case 'Z':
                            new_s += 'A';
                            break;
                        case 'z':
                            new_s += 'a';
                            break;
                        default:
                            new_s += alphabet_eng[alphabet_eng.IndexOf(symbol) + 1];
                            break;
                    }
                }
                else if (alphabet_rus.IndexOf(symbol) != -1)
                {
                    switch (symbol)
                    {
                        case 'Я':
                            new_s += 'А';
                            break;
                        case 'я':
                            new_s += 'а';
                            break;
                        default:
                            new_s += alphabet_rus[alphabet_rus.IndexOf(symbol) + 1];
                            break;
                    }
                }
                else if (Char.IsDigit(symbol))
                {
                    if (symbol == '9')
                    {
                        new_s += '0';
                    }
                    else
                    {
                        new_s += Convert.ToChar(Convert.ToByte(symbol) + 1);
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
            foreach (char symbol in s)
            {
                if (alphabet_eng.IndexOf(symbol) != -1)
                {
                    switch (symbol)
                    {
                        case 'A':
                            new_s += 'Z';
                            break;
                        case 'a':
                            new_s += 'z';
                            break;
                        default:
                            new_s += alphabet_eng[alphabet_eng.IndexOf(symbol) - 1];
                            break;
                    }
                }
                else if (alphabet_rus.IndexOf(symbol) != -1)
                {
                    switch (symbol)
                    {
                        case 'А':
                            new_s += 'Я';
                            break;
                        case 'а':
                            new_s += 'я';
                            break;
                        default:
                            new_s += alphabet_rus[alphabet_rus.IndexOf(symbol) - 1];
                            break;
                    }
                }
                else if (Char.IsDigit(symbol))
                {
                    if (symbol == '0')
                    {
                        new_s += '9';
                    }
                    else
                    {
                        new_s += Convert.ToChar(Convert.ToByte(symbol) - 1);
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