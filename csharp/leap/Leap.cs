using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if(DivisibleBy100Not400(year)) {
            return false;
        } else if(DivisibleBy4(year)) {
            return true;
        } else if(DivisibleBy400(year)) {
            return true;
        } else {
            return false;
        }
    }

    public static bool DivisibleBy100Not400(int year){
        return (DivisibleBy100(year) && !DivisibleBy400(year));
    }

    public static bool DivisibleBy4(int year){
        return DivisibleBy(4, year);
    }

    public static bool DivisibleBy400(int year){
        return DivisibleBy(400, year);
    }

    public static bool DivisibleBy100(int year){
        return DivisibleBy(100, year);
    }

    public static bool DivisibleBy(int divisor, int value){
        return (value % divisor == 0);
    }
}