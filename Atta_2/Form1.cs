using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BL;

namespace Atta_2
{
    public partial class Form1 : Form
    {
        /* Создать очередь, информационные поля которой содержат числа из текстового файла. Из каждой группы подряд идущих одинаковых чисел оставить только одно. */

        MyQueue my = new MyQueue();

        public Form1()
        {
            InitializeComponent();
        }

        private void Opn_Click(object sender, EventArgs e)
        {
            TF tF = new TF(Directory.GetCurrentDirectory() + "/Queue.txt");
            my = tF.Read();
            textBox1.Lines = my.Printer();
        }

        private void Resh_Click(object sender, EventArgs e)
        {
            MyQueue queue = MyQueue.Task(my);
            textBox1.Clear();
            textBox1.Lines = queue.Printer();
        }
    }
}
