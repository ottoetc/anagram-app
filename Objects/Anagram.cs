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
      char[] userWord2 = input2.ToCharArray();
      Array.Sort(userWord1);
      Array.Sort(userWord2);
      foreach (char letter in userWord1)
      {
        if ()
      }
    }
  }
}
