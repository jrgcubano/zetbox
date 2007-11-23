using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows.Markup;
using System.ComponentModel;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Automation;
using System.Diagnostics;

namespace Microsoft.Samples.KMoore.WPFSamples.BlockBarSample
{
    public class RectBlockBar : BlockBar
    {
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            Rect rect;
            int blockCount = BlockCount;
            Size renderSize = this.RenderSize;
            double blockMargin = this.BlockMargin;
            double value = Value;
            for (int i = 0; i < blockCount; i++)
            {
                rect = GetRect(renderSize, blockCount, blockMargin, i);

                if (!rect.IsEmpty)
                {
                    int threshold = GetThreshold(value, blockCount);
                    drawingContext.DrawRectangle((i < threshold) ? EnabledBrush : DisabledBrush, ThePen, rect);

                }
            }
        }


        private static Rect GetRect(Size targetSize, int blockCount, double blockMargin, int blockNumber)
        {
            if (targetSize.IsEmpty)
            {
                throw new ArgumentNullException();
            }
            if (blockCount < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (blockNumber >= blockCount)
            {
                throw new ArgumentOutOfRangeException();
            }

            double width = (targetSize.Width - (blockCount - 1) * blockMargin) / blockCount;
            double left = (width + blockMargin) * blockNumber;
            double height = targetSize.Height;

            if (width > 0 && height > 0)
            {
                return new Rect(left, 0, width, height);
            }
            else
            {
                return Rect.Empty;
            }
        }
    }
}
