using System;

namespace Anagram
{
  public class Anagram
  {
    public bool InputIsSame(string input1, string input2)
    {
      if (input1 == input2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsAnagram(string input1, string input2)
    {
      char[] userWord1 = input1.ToCharArray();
      string[] userWordList = input2.Split(' ');
      foreach (string word in userWordList)
      {
        char[] userWord2 = word.ToCharArray();
        Array.Sort(userWord1);
        Array.Sort(userWord2);
        if (new string(userWord1) == new string(userWord2))
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      return false;

    }
  }
}
