using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        List<int> knownMultiples = new List<int>();

        foreach(int baseMultiple in multiples){
            int factor = max / baseMultiple;
            for(int i = factor; i > 0; i--){
                int multiple = baseMultiple * i; 
                if(!knownMultiples.Contains(multiple) && multiple != max){
                    sum += multiple;
                    knownMultiples.Add(multiple);
                }
            }
        }
        return sum;
    }
}