using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6.Extensions
{
    public static class IntExtensions
    {
        public static bool IsGeaterThen (this int x, int y)
        {
            return x > y;
        }
    }
}
