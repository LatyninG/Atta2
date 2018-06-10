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

namespace SORT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV.ColumnCount = 1;
            DGV.ColumnHeadersVisible = false;
            DGV.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxUtils mbu = new MessageBoxUtils();
                int arraysize = mbu.DialogBox("Enter size of the array ", "Data input");
                if (arraysize == 0)
                    throw new Exception();
                ArrayUtils rr = new ArrayUtils(arraysize);
                int[] array = rr.ArrayCreater();
                ArrToDGV(array, DGV);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the correct data", "Error");
            } 
        }

        public static void ArrToDGV(int[] arr, DataGridView DGV)
        {
            DGV.Rows.Clear();
            DGV.RowCount = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                DGV.Rows[i].Cells[0].Value = arr[i];
            }
        }

        public static void ClearDGV(DataGridView DGV)
        {
            DGV.Rows.Clear();
        }

        public static int[] DGVToArr(DataGridView DGV)
        {
            int[] arr = new int[DGV.Rows.Count];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(DGV.Rows[i].Cells[0].Value);
            return arr;
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            ClearDGV(DGV);
            drawingPanel.BackColor = Color.White;
        }

        private void SortBTN_Click(object sender, EventArgs e)
        {
            int[] arr = DGVToArr(DGV);
            SortBL sort = new SortBL(arr.Length, arr);
            if (ShellRBTN.Checked)
            {
                sort.SortShell();
                ClearDGV(DGV);
                ArrToDGV(arr,DGV);
            }
            if (MoveRBTN.Checked)
            {
                sort.SortMove();
                ClearDGV(DGV);
                ArrToDGV(arr, DGV);
            }
        }

        private void SravBTN_Click(object sender, EventArgs e)
        {
            graphicCH.ChartAreas[0].CursorX.IsUserEnabled = true;
            graphicCH.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            graphicCH.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            graphicCH.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            graphicCH.ChartAreas[0].CursorY.IsUserEnabled = true;
            graphicCH.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            graphicCH.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            graphicCH.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            if(KObmenRBTN.Checked)
            {
                graphicCH.Series[0].Points.Clear();
                graphicCH.Series[1].Points.Clear();
                int[] arr = DGVToArr(DGV);
                for (int i = 0; i < arr.Length; i++)
                {
                    int[] tempArr = arr.Take(i).ToArray();
                    SortBL sort = new SortBL(tempArr.Length, tempArr);
                    sort.SortShell();
                    graphicCH.Series[1].Points.AddXY(i, sort.ReturnObm());
                    sort.SortMove();
                    graphicCH.Series[0].Points.AddXY(i, sort.ReturnObm());
                }
            }
            if (KSravRBTN.Checked)
            {
                graphicCH.Series[0].Points.Clear();
                graphicCH.Series[1].Points.Clear();
                int[] arr = DGVToArr(DGV);
                for (int i = 0; i < arr.Length; i++)
                {
                    int[] tempArr = arr.Take(i).ToArray();
                    SortBL sort = new SortBL(tempArr.Length, tempArr);
                    sort.SortShell();
                    graphicCH.Series[1].Points.AddXY(i, sort.ReturnSrav());
                    sort.SortMove();
                    graphicCH.Series[0].Points.AddXY(i, sort.ReturnSrav());
                }
            }
        }
    }


}
