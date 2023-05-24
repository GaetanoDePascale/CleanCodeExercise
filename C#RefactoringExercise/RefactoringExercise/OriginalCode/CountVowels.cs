using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise.OriginalCode
{
    internal class CountVowels
    {
        public static int VowelsNumber(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (vowels.Contains(ch))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
