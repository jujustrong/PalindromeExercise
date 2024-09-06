using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("radar", true)]
        [InlineData("refer", true)]
        [InlineData("noon", true)]
        [InlineData("mellow", false)]
        [InlineData("coffee", false)]
        [InlineData("level", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void AddTest(string word, bool expected)
        {
            //Arrange
            var newWord = new WordSmith();
            
            //Act
            var actual = newWord.IsAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
