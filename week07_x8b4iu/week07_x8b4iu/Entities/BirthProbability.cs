using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07_x8b4iu.Entities
{
    public class BirthProbability
    {
        public int Age { get; set; }
        public int NbrOfChildren { get; set; }
        public double BPobability { get; set; }
        public double BProbability { get; internal set; }
    }
}
