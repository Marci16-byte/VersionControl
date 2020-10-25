using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07_x8b4iu.Entities
{
    public class Person
    {
        public int BirtYear { get; set; }

        public Gender Gender { get; set; }

        public int NbrOfChildren { get; set; }

        public bool IsAlive { get; set; }
        public int BirthYear { get; internal set; }

        public Person()
        {
            IsAlive = true;
        }
    }
}
