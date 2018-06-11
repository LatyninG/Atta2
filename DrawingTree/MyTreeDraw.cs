using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BL;

namespace DrawingTree
{
    public class MyTreeDraw
    {
        private void DrawSubTree(NodeTree p, int L, int R, int y, int dy, Graphics g, DrawConfigTest dc)
        {
            int r = 20;
            if (p == null) return;
            int x = (L + R) / 2;
            if (p.left != null)
                g.DrawLine(dc.myPen, x, y, (L + x) / 2, y + dy);
            if (p.right != null)
                g.DrawLine(dc.myPen, x, y, (R + x) / 2, y + dy);
            g.FillEllipse(dc.myBrush, x - r, y - r, r * 2, r * 2);
            g.DrawEllipse(dc.myPen, x - r, y - r, r * 2, r * 2);
            string s = Convert.ToString(p.value);
            SizeF size = g.MeasureString(s, dc.myFont);
            g.DrawString(s, dc.myFont, Brushes.Black,
                 x - size.Width / 2,
                 y - size.Height / 2);

            if (p.left != null)
                DrawSubTree(p.left, L, x, y + dy, dy, g, dc);
            if (p.right != null)
                DrawSubTree(p.right, x, R, y + dy, dy, g, dc);
        }
        public Bitmap DrawTree(NodeTree p, int L, int R, int y, int dy, int height, DrawConfigTest dc = null)
        {
            if (dc == null)
                dc = new DrawConfigTest();
            Bitmap bitmap = new Bitmap(R, height);
            Graphics g = Graphics.FromImage(bitmap);
            DrawSubTree(p, L, R, y, dy, g, dc);
            return bitmap;
        }
    }
}
