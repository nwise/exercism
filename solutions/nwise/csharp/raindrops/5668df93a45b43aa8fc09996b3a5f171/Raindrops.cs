using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        String result = "";
        if(IsPling(number)) {
            result += "Pling";
        }
        if(IsPlang(number)) {
            result += "Plang";
        }
        if(IsPlong(number)){
            result += "Plong";
        }
        if(result == ""){
            result = number.ToString();
        }
        return result;
    }

    public static bool IsPling(int number)
    {
        return IsFactor(number, 3);
    }
    public static bool IsPlang(int number)
    {
        return IsFactor(number, 5);
    }
    public static bool IsPlong(int number)
    {
        return IsFactor(number, 7);
    }
    private static bool IsFactor(int number, int factor)
    {
        return (number % factor) == 0 ? true : false;
    }
}