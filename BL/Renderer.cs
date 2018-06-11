using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;

namespace BL
{
    public class Renderer
    {
        public enum HighLightType
        {
            Default, Comprasion, Swap
        };

        private static Dictionary<HighLightType, Brush> elemColorDict = new Dictionary<HighLightType, Brush>()
        {
            {HighLightType.Default, Brushes.LightGreen },
            {HighLightType.Comprasion, Brushes.LightYellow },
            {HighLightType.Swap, Brushes.LightPink }
        };

        private static Dictionary<HighLightType, Brush> elemBorderColorDict = new Dictionary<HighLightType, Brush>()
        {
            {HighLightType.Default, Brushes.DarkGreen },
            {HighLightType.Comprasion, Brushes.Yellow },
            {HighLightType.Swap, Brushes.Red }
        };

        private static int Inner = 20;
        private static int Space = 10;
        private static int Border = 5;

        public static Bitmap DrawArray(int width, int height, int[] arr, HashSet<int> selectedInd = null, HighLightType highLightType = HighLightType.Default)
        {
            Bitmap bit = new Bitmap(width, height);

            Graphics graph = Graphics.FromImage(bit);
            graph.Clear(Color.White);
            StringFormat elemStringForm = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            for (int i = 0; i < arr.Length; i++)
            {
                HighLightType currentElemHightLight;
                if (selectedInd != null && selectedInd.Contains(i))
                {
                    currentElemHightLight = highLightType;
                }
                else
                {
                    currentElemHightLight = HighLightType.Default;
                }
                Brush elemColor = elemColorDict[currentElemHightLight];
                Brush elemBorderColor = elemBorderColorDict[currentElemHightLight];
                Point position = ElementPos(width, height, i);
                Rectangle rectangle = new Rectangle(position.X - Inner, position.Y - Inner, Inner * 2, Inner * 2);
                graph.FillEllipse(elemBorderColor, rectangle.Left - Border, rectangle.Top - Border, rectangle.Width + 2 * Border, rectangle.Height + 2 * Border);

                graph.FillEllipse(elemColor, rectangle);

                graph.DrawString(arr[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, rectangle, elemStringForm);
            }
            return bit;
        }

        private static Point ElementPos(int width, int height, int index)
        {
            int elemSize = Inner + Space;

            int elemRow = width / (elemSize * 2);

            int x = (2 * (index % elemRow) + 1) * elemSize;
            int y = (2 * (index / elemRow) + 1) * elemSize;

            return new Point(x, y);
        }
    }
}
