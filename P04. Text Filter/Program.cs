using System;

namespace P04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine().Split(new char[] {' ', ',','.','*' });
            string text = Console.ReadLine();
            foreach (var word in bannedWord)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
