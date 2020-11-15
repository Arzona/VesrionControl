using _8_gyak_fejlesztesi_mintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_gyak_fejlesztesi_mintak.Entities
{
    public class Ball : Toy
    {
              
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

       

        
    }
}
