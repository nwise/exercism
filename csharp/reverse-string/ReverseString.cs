using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] CharList = input.ToCharArray();
        Array.Reverse(CharList);
        string Reversed = new string(CharList);

        return Reversed; 
    }
}