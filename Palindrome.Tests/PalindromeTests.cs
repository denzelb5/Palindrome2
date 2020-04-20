using System;
using Xunit;

namespace Palindrome2.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void IsStarsPalindrome()
        {
            // Arrange
            var palindrome = "stars";
            var expectedResult = false;
            var checkWord = new PalindromeChecker();

            // Actual
            var actualResult = checkWord.CheckPalindrome(palindrome);

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void IsPalindrome2()
        {
            // Arrange
            var palindrome = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var checkWord = new PalindromeChecker();

            // Actual
            var actualResult = checkWord.CheckPalindrome(palindrome);

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void IsPalindrome3()
        {
            // Arrange
            var palindrome = "Some men interpret nine memos";
            var expectedResult = true;
            var checkWord = new PalindromeChecker();

            // Actual
            var actualResult = checkWord.CheckPalindrome(palindrome);

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
