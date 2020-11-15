using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using week08.Abstractions;
namespace week08.Entities
{
    class Present
    {
        public SolidBrush RibbonColor { get; private set; }

        public SolidBrush BoxColor { get; private set; }

        public Present(Color ribbon, Color box)
        {
            RibbonColor = new SolidBrush(ribbon);
            BoxColor = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 0, 20, Width, Height / 5);
            g.FillRectangle(RibbonColor, 20, 0, Width / 5, Height);
        }
    }
}
