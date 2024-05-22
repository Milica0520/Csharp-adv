using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6.Extensions
{
    public static class StringExtensions
    {
        public static string Shorten(string sentence, int keepNumOgWords)
        {
            string result = string.Empty;

            string[] words = sentence.Split(" ");

            for (int i = 0; i < keepNumOgWords; i++)
            {
                result = result + " " + words[i]; 
            }
            result = result + "... ";
            return result;
        }

    }
}
