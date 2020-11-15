using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace week08.Entities
{
    class PresentFactory
    {
        public Color RibbonColor { get; set; }

        public Color BoxColor { get; set; }

        public Toy CreateNew()
        {
            return new Present(RibbonColor, BoxColor);
        }
    }
}
