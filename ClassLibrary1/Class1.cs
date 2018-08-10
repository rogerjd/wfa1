using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string HelloMsg(string name)
        {
            string res = "Hello";
            if (string.IsNullOrWhiteSpace(name))
            {
                res += "!";
            }
            else
            {
                res += " " + name + "!";
            }
            return res;
        }
    }
}
