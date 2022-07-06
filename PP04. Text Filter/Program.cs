using System;

namespace PP04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] {' ', ',', '.', '!', '*' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                input = input.Replace(word, new string('*', word.Length));

            }
            Console.WriteLine(input);
        }
    }
}
