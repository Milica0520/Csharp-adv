using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Models
{
    public class WebPage : Document, ISearchable
    {
        public List<string> Words { get; set; }

        public WebPage(List<string> words)
        {
            Words = words;

        }

        public override void Search(string word)
        {

            List<string> foundWord = Words.Where(text => text.Contains(word)).ToList();
     
            
                if (foundWord.Count > 0)
                {   
                        Console.WriteLine($"Word {word} found");
                }
                else
                {
                    Console.WriteLine($"Word {word} not found in the text.");
                }
            

        }
    }
}
