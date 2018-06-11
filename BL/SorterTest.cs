using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SorterTest
    {
        public static void BubleSortRender(int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            BubleSort(true, canvasWidth, canvasHeight, arr, out report);
        }

        public static void Buble(int[] arr, out SortReport report)
        {
            BubleSort(false, 0, 0, arr, out report);
        }

        private static void BubleSort (bool render, int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            report = (render) ? new SortReport(canvasWidth, canvasHeight) : new SortReport();

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for(int j = n-1; j > i; j--)
                    if(Compare(arr,i,j,report) == 1)
                    {
                        Swap(arr, i, j, report);
                    }
        }

        public static void Shell(int[] arr, out SortReport report)
        {
            ShellSort(false, 0, 0, arr, out report);
        }

        public static void ShellSortRender(int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            ShellSort(true, canvasWidth, canvasHeight, arr, out report);
        }

        private static void ShellSort(bool render, int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            report = (render) ? new SortReport(canvasWidth, canvasHeight) : new SortReport();

            int d = arr.Length / 2;
            while (d > 0)
            {
                bool Ok = true;
                while (Ok)
                {
                    Ok = false;
                    for (int i = 0; i < arr.Length - d; i++)
                    {
                        if (Compare(arr, i, i+d, report) == 1)
                        {
                            Swap(arr, i, i + d, report);
                            Ok = true;
                        }
                    }
                }
                d = d / 2;
            }
        }

        private static int Compare(int[] arr, int index1, int index2, SortReport report)
        {
            report.ComparisonsCount++;

            if (report.Render)
                RenderComparison(arr, index1, index2, report);

            return (arr[index1] == arr[index2]) ? 0 : (arr[index1] > arr[index2]) ? 1 : -1;
        }

        private static void Swap(int[] arr, int index1, int index2, SortReport report)
        {
            report.SwapsCount++;

            if (report.Render)
                RenderSwap(arr, index1, index2, report);

            int t = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = t;

            if (report.Render)
                RenderComparison(arr, index1, index2, report);
        }

        private static void RenderComparison(int[] arr, int index1, int index2, SortReport report)
        {
            report.Frames.Add(Renderer.DrawArray(report.CanvasWidth, report.CanvasHeight, arr, new HashSet<int>() { index1, index2 }, Renderer.HighLightType.Comprasion));
        }

        private static void RenderSwap(int[] arr, int index1, int index2, SortReport report)
        {
            report.Frames.Add(Renderer.DrawArray(report.CanvasWidth, report.CanvasHeight, arr, new HashSet<int>() { index1, index2 }, Renderer.HighLightType.Swap));
        }
    }
}
