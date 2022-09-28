using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seepass
{
    internal class Schema
    {
        public string zipFilename { get; set; }
        public List<PasswordRule> passwordRules { get; set; }
    }
}
