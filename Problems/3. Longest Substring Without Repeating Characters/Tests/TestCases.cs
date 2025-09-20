
namespace Tests;

using Solution;
using NUnit.Framework;

public class Tests
{
    public SolutionComponent SolutionComponentInstance;
    [SetUp]
    public void Setup()
    {
        SolutionComponentInstance = new SolutionComponent();
    }

    [Test]
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("", 0)]
    [TestCase("au", 2)]
    public void LengthOfLongestSubstring_Test(string input, int expected)
    {
        int result = SolutionComponentInstance.LengthOfLongestSubstring(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}
