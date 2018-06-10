using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyTree tree = new MyTree();
        DrawConfig dc = new DrawConfig();
        MessageBoxUtils mbu = new MessageBoxUtils();

        public void MyDraw()
        {
            Bitmap bitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            dc.g = Graphics.FromImage(bitmap);
            dc.g.Clear(Color.Black);
            if (bitmap != null)
            {
                bitmap = tree.DrawTree(tree.GetRoot(), 0, drawingPanel.Width, 20, 90, drawingPanel.Height);
                drawingPanel.CreateGraphics().DrawImage(bitmap, 0, 0);
            }
        }
        int levelamount = 0;

        private void generateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string levelsAndChance = MessageBoxUtils.DialogBoxTree("Enter the amount of levels and their generation chance", "Ввод");
                if (levelsAndChance == "")
                    throw new Exception();
                string[] str = levelsAndChance.Split(' ');
                if (str.Length > 2)
                    throw new Exception();
                levelamount = Convert.ToInt32(str[0]);
                double chance = Convert.ToDouble(str[1]);
                tree.RandomTreeGenerator(levelamount, chance);
                MyDraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the correct value", "Error");
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            tree = new MyTree();
            Bitmap bitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            drawingPanel.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        private void solveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string level = MessageBoxUtils.DialogBoxTree("Enter the level's number", "Set the task params");
                int y = 0;
                if (level == "" || !(Int32.TryParse(level, out y)) || y < 0)
                    throw new Exception();
                if (y <= levelamount)
                {
                    int x = tree.CountTree(levelamount, levelamount - y);//n-уровней всего,k-искомый уровень
                    MessageBox.Show("Value's sum on the chosen level: " + Convert.ToString(x), "Result");
                }
                else MessageBox.Show("Our tree hasnt got this level", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the correct value");
            }
        }
    }
}
