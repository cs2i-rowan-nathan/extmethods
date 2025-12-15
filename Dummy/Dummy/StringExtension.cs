using System;
using System.Collections.Generic;
using System.Text;

namespace Dummy
{
    public static class StringExtension
    {
        public static string FirstLetter(this string s)
        {
            return s == "" ? "":s.Substring(0,1);
        }
    }
}
