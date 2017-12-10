using System;

  public static class TwoFer
  {
      public static string Name(string input = null)
      {
        string name = input == null ? "you" : input;
        return $"One for {name}, one for me.";
      }
  }