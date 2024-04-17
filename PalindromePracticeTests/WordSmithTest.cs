using PalindromePractice;

namespace PalindromePracticeTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("RaceCar", true)]
        [InlineData("rotator", true)]
        [InlineData("Rotator", true)]
        [InlineData("123454321", true)]
        [InlineData("hello", false)]
        [InlineData("House", false)]
        [InlineData("8635123", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            // Arrange
            // Create a WordSmith object
            WordSmith wordSmithTest = new WordSmith();

            // Act
            bool actual = wordSmithTest.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}