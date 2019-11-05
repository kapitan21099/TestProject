using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.Enter your word");
            string word = Console.ReadLine();
            if (IsContainsOnlyLetters(word))
            {
                int timer = 0;
                for (int i = 0; i <= (word.Length / 2 - 1); i++)
                {
                    if (word[i] == word[word.Length - 1 - i])
                    {
                        timer++;
                    }
                }
                if (timer == word.Length / 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" This word is polindrom");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This word is not polindrom");
                }
            }
            else if (IsOnlySpaces(word))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your word has {0} spaces. Is polindrom", word.Length);
            }
            else
            {
                Console.WriteLine("Not all characters are letters.Please try again");
            }
            Console.ReadLine();
        }
        static bool IsContainsOnlyLetters(string word)
        {
            for (int i = 0; i < word.Length; ++i)
            {
                char elementOfWord = word[i];
                if (!char.IsLetter(elementOfWord))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsOnlySpaces(string word)
        {
            for (int i = 0; i < word.Length; ++i)
            {
                char elementOfWord = word[i];
                if (elementOfWord != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
