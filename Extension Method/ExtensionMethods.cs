using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    internal static class ExtensionMethods
    {
        public static int GetWordCount(this string str) => str.Split(' ').Length;

    }
}
