using Xunit;
namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void AnagramTest_StringsMatchTrue()
    {
      var testAnagram = new Anagram();
      Assert.Equal(true, testAnagram.InputIsSame("n", "n"));
    }
    [Fact]
    public void AnagramTest_StringsMatchFalse()
    {
      var testAnagram = new Anagram();
      Assert.Equal(false, testAnagram.InputIsSame("n", "a"));
    }
    [Fact]
    public void AnagramTest_StringIsAnagramTrue()
    {
      // var testAnagram = new Anagram();
      // Assert.Equal(true, testAnagram.IsAnagram("read", "dear"));
    }
  }
}
