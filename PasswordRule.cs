using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seepass
{
    internal class PasswordRule
    {
        public string passwordSymbol { get; set; }
        public int passwordCount { get; set; }
        public int passwordPosition { get; set; }
        public string isCapitalized { get; set; }
    }
}
