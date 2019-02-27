using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSafe
{
    public class OpenFile
    {
        public string Name { get; set; }

        public string Path { get; set; }

        // returns true if encrypted
        public bool Encrypted { get; set; }

        // stores the contents of the file
        public string Contents { get; set; }
    }
}
