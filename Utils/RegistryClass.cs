using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tzoptimizer.Utils
{
    internal class RegistryClass
    {
        public string Root { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public Dictionary<string, string> KeyValuePairs = new Dictionary<string, string>();
    }
}
