using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {

        int StepCount = 0;
        int Result = number;

        while(Result != 1) {
          if(Result <= 0) {
            throw new ArgumentException();
          } else if (IsOdd(Result)) {
              Result = HandleOdd(Result);
          } else {
              Result = HandleEven(Result);
          }
          StepCount++;
        }
        return StepCount;
    }

    public static int HandleEven(int number){
      return number / 2;       
    }

    public static int HandleOdd(int number){
      return (3 * number) + 1;
    }

    private static bool IsOdd(int number){
        if(number % 2 == 0){
            return false;
        } else {
            return true;
        }
    }
}