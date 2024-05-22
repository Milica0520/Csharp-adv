using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class PrintInConsole<T>
    {
        public List<T> Collection = new List<T>();
        public void Print(T obj)
        {
            Console.WriteLine(obj);
        }

        public void PrintCollection()
        {

            foreach (T item in Collection)
            {
                Print(item);
            }


        }
    }
}
