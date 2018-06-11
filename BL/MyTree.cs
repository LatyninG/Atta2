using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class MyTree
    {
        public int counter;
        private NodeTree root;
        Random rnd = new Random();
        public MyTree()
        {
            root = null;
        }
        public NodeTree GetRoot()
        {
            return root;
        }
        public void RandomTreeGenerator(int level, double chance)
        {
            int n = level;
            root = GenerateTheSubTree(level, chance, n);
        }
        private NodeTree GenerateTheSubTree(int level, double chance, int n)
        {
            if (level <= 0)
                return null;
            if (rnd.NextDouble() >= chance && level != n)
                return null;
            NodeTree p = new NodeTree();
            p.value = rnd.Next(0, 20);
            p.left = GenerateTheSubTree(level - 1, chance, n);
            p.right = GenerateTheSubTree(level - 1, chance, n);
            return p;
        }
     /*   private void DrawSubTree(NodeTree p, int L, int R, int y, int dy, Graphics g, DrawConfig dc)
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
        public Bitmap DrawTree(NodeTree p, int L, int R, int y, int dy, int height, DrawConfig dc = null)
        {
            if (dc == null)
                dc = new DrawConfig();
            Bitmap bitmap = new Bitmap(R, height);
            Graphics g = Graphics.FromImage(bitmap);
            DrawSubTree(p, L, R, y, dy, g, dc);
            return bitmap;
        } */
        private int CountSubTree(NodeTree p, int n, int k)
        {
            counter = 0;
            if (p == null)
                return 0;
            if (n == k + 1)
            {
                counter = 1;
                return counter;
            }
            return CountSubTree(p.left, n - 1, k) + CountSubTree(p.right, n - 1, k);
        }
        public int CountTree(int n, int k)
        {
            return CountSubTree(root, n, k);
        }
    }
}
