using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class9.Utils
{
    public class OurTextWriter : IDisposable
    {
        private string _path;

        private bool _disposedValue = false;

        private StreamWriter _streamWriter;


        public OurTextWriter(string path)
        {
            _path = path;
           
            _streamWriter = new StreamWriter(path);
        }

        public void Write(string content)
        {
            _streamWriter.Write(content);
        }
        //Here you can clean all the members and 
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
