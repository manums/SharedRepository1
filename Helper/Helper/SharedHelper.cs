using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class SharedHelper
    {
        public int GetLength(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            return str.Length;
        }
    }
}
