using System;
using System.Text;

namespace PP02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var res = new StringBuilder();
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    res.Append(word);
                }

            }
            Console.WriteLine(res);
        }
    }
}
