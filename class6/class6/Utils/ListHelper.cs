using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6.Utils
{
    public class ListHelper<T>
    {
        public void GoThroughList(List<T> listOfItems)
        {
            foreach (T word in listOfItems) 
            {
            Console.WriteLine(word);
            }
        }

        public void GetInfo(List<T> listOfItems)
        {
            Console.WriteLine($"{listOfItems.GetType().FullName}");
        }



    }
}
