using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpExamples.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int Userid { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
    }
}
