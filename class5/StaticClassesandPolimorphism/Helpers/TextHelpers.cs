using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesandPolimorphism.Helpers
{
    public static class TextHelpers
    {
        public static int CapitalFirstUsers = 0;
        public static string CapitalFirstLetter(string word)
        {


            string editedWord = "";

            if (word.Length == 0)
            {
                return "Empry word";
            }
            if (word.Length == 1)
            {
                editedWord = char.ToUpper(word[0]).ToString();

            }
            else
            {
                editedWord = char.ToUpper(word[0]) + word.Substring(1);
            }
            CapitalFirstUsers++;
            return editedWord;
        }

        public static string InvertString(string word)
        {
            string editedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
               
                if (char.IsUpper(word[i]))
                         editedWord += char.ToLower(word[i]);
                else
                    editedWord += char.ToLower(word[i]);
            }

            return editedWord;
        }

        public static int countUppers(string word)
        {

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                    count++;
            }
            return count;
        }

    }
}
