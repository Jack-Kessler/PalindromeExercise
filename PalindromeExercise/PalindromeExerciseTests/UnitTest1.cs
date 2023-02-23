using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("dog", false)]
        [InlineData("kayak", true)]
        [InlineData("KAyak", true)]
        [InlineData("Minnesota", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("dog", false)]
        [InlineData("a", false)]
        [InlineData("i", false)]
        public void IsAPalindromeTest(string str, bool expected)
        {
            //Arrange
            WordSmith test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(str);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
