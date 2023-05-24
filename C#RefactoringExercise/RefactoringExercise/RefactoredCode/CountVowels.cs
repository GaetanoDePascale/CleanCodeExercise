using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RefactoringExercise.RefactoredCode
{
    internal class Vowels
    {
        public static int count(string input)
        {
            Regex vowelRegex = new("[aeiou]", RegexOptions.IgnoreCase);

            return vowelRegex.Matches(input).Count();
        }
    }
}
