using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var palinWord = new WordSmith();
            Console.WriteLine(palinWord.IsAPalindrome("racecar"));
            Console.WriteLine(palinWord.IsAPalindrome("civic"));
            Console.WriteLine(palinWord.IsAPalindrome("bandit"));
            Console.WriteLine(palinWord.IsAPalindrome("fox"));



        }




    }
}
