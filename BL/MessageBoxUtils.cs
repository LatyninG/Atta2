using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BL
{
    public class MessageBoxUtils
    {
        public int DialogBox(string text, string caption)
        {
            Form dialogbox = new Form()
            {
                Width = 330,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false
            };
            Label label = new Label()
            {
                Left = 25,
                Top = 10,
                Text = text,
                AutoSize = true,
            };
            dialogbox.Controls.Add(label);

            NumericUpDown nud = new NumericUpDown()
            {
                Left = 160,
                Top = 10,
                Maximum = 1000,
            };
            dialogbox.Controls.Add(nud);

            Button confirmBTN = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 90,
                Top = 35,
                DialogResult = DialogResult.OK
            };
            dialogbox.AcceptButton = confirmBTN;
            dialogbox.Controls.Add(confirmBTN);
            return dialogbox.ShowDialog() == DialogResult.OK ? Convert.ToInt32(nud.Value) : 0;

        }

        public static string DialogBoxTree(string text, string caption)
        {
            Form dialogbox = new Form()
            {
                Width = 330,
                Height = 140,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
            };
            Label label = new Label()
            {
                Left = 25,
                Top = 10,
                Text = text,
                AutoSize = true,
            };

            dialogbox.Controls.Add(label);

            TextBox tb = new TextBox()
            {
                Left = 25,
                Top = 40,
                Width = 270,
            };

            dialogbox.Controls.Add(tb);

            Button confirmBTN = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 100,
                Top = 70,
                DialogResult = DialogResult.OK
            };
            dialogbox.AcceptButton = confirmBTN;
            dialogbox.Controls.Add(confirmBTN);
            return dialogbox.ShowDialog() == DialogResult.OK ? tb.Text : null;

        }
    }
}
