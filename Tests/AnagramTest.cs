using Xunit;
namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void AnagramTest_StringsMatchTrue()
    {
      var testAnagram = new Anagram();
      Assert.Equal(true, testAnagram.IsAnagram("n", "n"));
    }
    [Fact]
    public void AnagramTest_StringsMatchFalse()
    {
      var testAnagram = new Anagram();
      Assert.Equal(false, testAnagram.IsAnagram("n", "a"));
    }
    [Fact]
    public void AnagramTest_StringIsAnagramTrue()
    {
      var testAnagram = new Anagram();
      Assert.Equal(true, testAnagram.IsAnagram("read", "dear"));
    }
    [Fact]
    public void AnagramTest_StringIsAnagramFalse()
    {
      var testAnagram = new Anagram();
      Assert.Equal(false, testAnagram.IsAnagram("read", "reed"));
    }
    [Fact]
    public void AnagramTest_MultipleAreAnagramsTrue()
    {
      var testAnagram = new Anagram();
      Assert.Equal(true, testAnagram.IsAnagram("read", "dare dear"));
    }
    [Fact]
    public void AnagramTest_MultipleAreAnagramsFalse()
    {
      var testAnagram = new Anagram();
      Assert.Equal(false, testAnagram.IsAnagram("read", "zare zear"));
    }
  }
}
