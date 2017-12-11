using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        // `10 != 1^2 + 0^2 = 2`
        // `153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153`

        IEnumerable<int> list = NumberList(number);
        int power = list.Count();
        int result = 0;

        foreach(int num in list){
            result += (int)Math.Pow(Convert.ToInt32(num), power);
        }

        if(number == result){
            return true;        
        } else {
            return false;
        }
    }

    public static IEnumerable<int> NumberList(int number){
        String numberString = number.ToString();
        return numberString.Select(digit => int.Parse(digit.ToString()));
        // return numberString.Split();
    }
}