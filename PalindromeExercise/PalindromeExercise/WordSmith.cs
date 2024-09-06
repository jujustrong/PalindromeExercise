
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return false;
        }
        var reversedWord = new string(word.ToLower().Reverse().ToArray());
        return word.ToLower() == reversedWord;
    }



}