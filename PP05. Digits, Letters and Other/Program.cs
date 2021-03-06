using System;
using System.Text;

namespace PP05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var numbers = new StringBuilder();
            var letters = new StringBuilder();
            var others = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {


                var charInput = input[i];
                if (char.IsDigit(charInput))
                {
                    numbers.Append(charInput);
                }
                else if (char.IsLetter(charInput))
                {
                    letters.Append(charInput);
                }
                else
                {
                    others.Append(charInput);
                }




            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
