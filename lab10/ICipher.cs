using System;

namespace lab10
{
    internal interface ICipher
    {
        string Encode(string s);
        string Decode(string s);
    }
}