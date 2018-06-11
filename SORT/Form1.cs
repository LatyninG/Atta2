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
using System.Collections.Generic;

namespace SORT
{
    public partial class Form1 : Form
    {
        /* Написать программу, которая наглядно иллюстрирует работу следующих методов сортировки: 1) Пузырьковая; 2) Шелла.
        Провести сравнение этих сортировок по количеству сравнений, по количеству обменов.
        Для этого построить графики зависимостей данных величин от количества элементов массив*/

        int[] draw_Arr;

        DoubleLinkedListNode<Bitmap> _currentFrame;

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
                draw_Arr = array;
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
            else if (BubleRBTN.Checked)
            {
                sort.BubleSort();
                ClearDGV(DGV);
                ArrToDGV(arr, DGV);
            }
            else
            {
                MessageBox.Show("Выберите вид сортировки");
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
 //               int[] arr = DGVToArr(DGV);
                for (int i = 0; i < draw_Arr.Length; i++)
                {
                    int[] tempArr = draw_Arr.Take(i).ToArray();
                    SortBL sort = new SortBL(tempArr.Length, tempArr);
                    sort.SortShell();
                    graphicCH.Series[1].Points.AddXY(i, sort.ReturnObm());
                    sort.BubleSort();
                    graphicCH.Series[0].Points.AddXY(i, sort.ReturnObm());
                }
            }
            else if (KSravRBTN.Checked)
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
                    sort.BubleSort();
                    graphicCH.Series[0].Points.AddXY(i, sort.ReturnSrav());
                }
            }
            else
            {
                MessageBox.Show("Выберите тип графика для построения.");
            }
        }

        private void DemonstrateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShellRBTN.Checked)
                {
                    int[] demonstrate_Arr = draw_Arr;

                    SorterTest.ShellSortRender(drawingPanel.Width, drawingPanel.Height, demonstrate_Arr, out SortReport report);

                    _currentFrame = report.Frames.First;

                    while (_currentFrame != null)
                    {
                        drawingPanel.CreateGraphics().DrawImage(_currentFrame.Value, 0, 0);
                        System.Threading.Thread.Sleep(500);

                        _currentFrame = _currentFrame.Next;
                    }

                    ArrToDGV(demonstrate_Arr, DGV);
                }
                else if (BubleRBTN.Checked)
                {
                    int[] demonstrate_Arr = draw_Arr;

                    SorterTest.BubleSortRender(drawingPanel.Width, drawingPanel.Height, demonstrate_Arr, out SortReport report);

                    _currentFrame = report.Frames.First;

                    while (_currentFrame != null)
                    {
                        drawingPanel.CreateGraphics().DrawImage(_currentFrame.Value, 0, 0);
                        System.Threading.Thread.Sleep(500);

                        _currentFrame = _currentFrame.Next;
                    }

                    ArrToDGV(demonstrate_Arr, DGV);
                }
                else
                {
                    MessageBox.Show("Выберите вид сортировки.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте корректность ваших данных.");
            }
        }
    }


}
