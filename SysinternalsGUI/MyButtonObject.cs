using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysinternalsGUI
{
    class MyButtonObject : UserControl
    {
        // Draw the new button.
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Transparent);
            // Draw the button in the form of a circle
            graphics.DrawEllipse(myPen, 0, 0, 14, 14);
            myPen.Dispose();
        }
    }
}
