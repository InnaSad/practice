using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2
{
    class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            Pen drawingpen = new Pen(Brushes.Black, 2);
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);

            drawingContext.DrawLine(drawingpen, new Point(10, 50), new Point(50, 10));
            drawingContext.DrawLine(drawingpen, new Point(50, 10), new Point(100, 50));
            drawingContext.DrawLine(drawingpen, new Point(10, 50), new Point(100, 50));
            drawingContext.DrawEllipse(null, drawingpen, new Point(160, 30), 50, 20);
            drawingContext.DrawEllipse(brush, drawingpen, new Point(250, 30), 20, 20);
            Rect rect = new Rect(290, 10, 80, 40);
            drawingContext.DrawRectangle(brush, drawingpen, rect);

            drawingContext.DrawEllipse(null, drawingpen, new Point(60, 110), 50, 50);
            drawingContext.DrawEllipse(null, drawingpen, new Point(60, 110), 40, 40);
            drawingContext.DrawEllipse(null, drawingpen, new Point(60, 110), 20, 20);

            Rect rect1 = new Rect(130, 70, 40, 70);
            Rect rect2 = new Rect(150, 120, 40, 70);
            Rect rect3 = new Rect(170, 170, 40, 70);
            Rect rect4 = new Rect(190, 220, 40, 70);
            Rect rect5 = new Rect(210, 270, 40, 70);
            drawingContext.DrawRectangle(null, drawingpen, rect1);
            drawingContext.DrawRectangle(null, drawingpen, rect2);
            drawingContext.DrawRectangle(null, drawingpen, rect3);
            drawingContext.DrawRectangle(null, drawingpen, rect4);
            drawingContext.DrawRectangle(null, drawingpen, rect5);
            base.OnRender(drawingContext);
        }
    }
}