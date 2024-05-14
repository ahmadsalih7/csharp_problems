using System;

char[] f(char[] a, int start, int len)
{
    if (start < 0 || len < 0 || start + len > a.Length)
    {
        return null;
    }
    return new string(a).Substring(start, len).ToCharArray();
}

char[] chars = { 'a', 'b', 'c' };
Console.WriteLine(f(chars, 1, 2));

