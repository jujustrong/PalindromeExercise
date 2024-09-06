using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        var reversedWord = new string(word.ToLower().Reverse().ToArray());
        return word.ToLower() == reversedWord;
    }



}