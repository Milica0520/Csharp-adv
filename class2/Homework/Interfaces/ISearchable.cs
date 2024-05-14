using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Interfaces
{
    public interface ISearchable
    {
        public string Word { get; set; }
        void Search(string word);
    }
}
