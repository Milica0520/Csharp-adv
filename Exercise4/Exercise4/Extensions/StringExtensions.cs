using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise4.Extensions
{
    public static class StringExtensions
    {
        public static string ReverseWords(this string sentence)
        {
            char[] sentenceToReverse = sentence.ToCharArray();
            string reversedSentence = String.Empty;
            for (int i = sentenceToReverse.Length - 1; i > -1; i--)
            {
                reversedSentence += sentenceToReverse[i];
            }
            return reversedSentence;


        }
    }
}
