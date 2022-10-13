using System;
class Program 
{
     static bool IsPalindrome(string word)
    {
        if (word.Length <= 1)
            return true;
        else
        {
            if (word[0] != word[word.Length - 1])
                return false;
            else
                return IsPalindrome(word.Substring(1, word.Length - 2));
        }
    }
    public static void Main()
    {
        Console.WriteLine(" Check the word : ");
        string st;
        bool tf;

        Console.WriteLine(" Input the word : ");
        st = Console.ReadLine();
        tf = IsPalindrome(st);
        if (tf == true)
        {
            Console.WriteLine(" The word is Palindrome.");
        }
        else
        {
            Console.WriteLine(" The word is not a Palindrome.");
        }
    }
}
