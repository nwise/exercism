using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if(Empty(statement)) {
            return "Fine. Be that way!";
        } else if(Shouting(statement)) {
            return "Whoa, chill out!";
        } else if(Question(statement)) {
            return "Sure.";
        } else {
            return "Whatever.";
        }
    }

    public static Boolean Empty(string statement)
    {
        Regex empty = new Regex(@"^[\n\r\t ]*$");
        return empty.IsMatch(statement);
    }

    public static Boolean Question(string statement)
    {
        Regex question = new Regex(@"^[a-zA-Z0-9 ,.:)!]*\?[ ]*$");

        if(question.IsMatch(statement)){
            return true;
        } else {
            return false;
        }
    }

    public static Boolean Shouting(string statement){

        Regex shouting = new Regex(@"^[A-Z+0-9 ,!%^*@#$(*^]*$");
        Regex allCaps = new Regex(@"^[A-Z ]+[0-9 ]*[!?]$");
        Regex onlyNumbers = new Regex(@"^[0-9, ]*$");

        if(onlyNumbers.IsMatch(statement)) {
            return false;
        } else if(allCaps.IsMatch(statement)) {
            return true;
        } else if(shouting.IsMatch(statement)) {
            return true;
        } else {
            return false;
        }
    }

}