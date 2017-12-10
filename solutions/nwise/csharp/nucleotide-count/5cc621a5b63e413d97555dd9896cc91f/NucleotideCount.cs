using System;
using System.Collections.Generic;

public class NucleotideCount
{
    private IDictionary<char, int> nucleotides = new Dictionary<char, int>() {
        ['A'] = 0,
        ['C'] = 0,
        ['G'] = 0,
        ['T'] = 0
    };
    public NucleotideCount(string sequence)
    {
        foreach(char nucleotide in sequence){
            if(nucleotides.ContainsKey(nucleotide)){
                nucleotides[nucleotide]++;          
            } else {
                throw new InvalidNucleotideException();
            }
        }
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return nucleotides;
        }
    }
}

public class InvalidNucleotideException : Exception { }