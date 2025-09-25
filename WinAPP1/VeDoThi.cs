using Ptbac2;
using System.Windows.Forms;
using System.Drawing;

class ve_do_thi
{
    public static Bitmap draw_bitmap(double a, double b, double c, int width, int height)
    {
        Bitmap bmp = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(Color.White);

            int w = bmp.Width;
            int h = bmp.Height;

            // Tạo đối tượng Pt_thuc để tính nghiệm
            Pt_thuc pt = new Pt_thuc(a, b, c);
            var (x1, x2, numNghiem) = pt.TinhNghiem();

            // Xác định dải x để vẽ
            double xMin = -10, xMax = 10;
            if (numNghiem == 1)
            {
                double xr = x1.Value;
                xMin = xr - 5;
                xMax = xr + 5;
            }
            else if (numNghiem == 2)
            {
                double xrMin = Math.Min(x1.Value, x2.Value);
                double xrMax = Math.Max(x1.Value, x2.Value);
                double padding = 2;
                xMin = xrMin - padding;
                xMax = xrMax + padding;
            }

            // Tìm yMin, yMax
            double yMin = a * xMin * xMin + b * xMin + c;
            double yMax = yMin;
            for (double x = xMin; x <= xMax; x += (xMax - xMin) / w)
            {
                double y = a * x * x + b * x + c;
                if (y < yMin) yMin = y;
                if (y > yMax) yMax = y;
            }
            double yPadding = (yMax - yMin) * 0.1;
            yMin -= yPadding;
            yMax += yPadding;

            // Vẽ lưới
            Pen gridPen = new Pen(Color.LightGray, 1);
            Font font = new Font("Arial", 8);
            Brush brush = Brushes.Black;

            int zeroX = (int)((0 - xMin) / (xMax - xMin) * w);
            int zeroY = (int)((yMax - 0) / (yMax - yMin) * h);

            // Vẽ các đường ngang
            int numYLines = 10;
            for (int i = 0; i <= numYLines; i++)
            {
                double yVal = yMin + i * (yMax - yMin) / numYLines;
                int py = (int)((yMax - yVal) / (yMax - yMin) * h);
                g.DrawLine(gridPen, 0, py, w, py);
                g.DrawString(yVal.ToString("F1"), font, brush, zeroX + 2, py - 10);
            }

            // Vẽ các đường dọc
            int numXLines = 10;
            for (int i = 0; i <= numXLines; i++)
            {
                double xVal = xMin + i * (xMax - xMin) / numXLines;
                int px = (int)((xVal - xMin) / (xMax - xMin) * w);
                g.DrawLine(gridPen, px, 0, px, h);
                g.DrawString(xVal.ToString("F1"), font, brush, px + 2, zeroY + 2);
            }

            // Vẽ trục Oxy
            Pen axisPen = new Pen(Color.Black, 1);
            g.DrawLine(axisPen, 0, zeroY, w, zeroY); // trục X
            g.DrawLine(axisPen, zeroX, 0, zeroX, h); // trục Y

            // Vẽ đồ thị parabola
            Pen curvePen = new Pen(Color.Red, 2);
            Point? prevPoint = null;
            for (int i = 0; i <= w; i++)
            {
                double x = xMin + i * (xMax - xMin) / w;
                double y = a * x * x + b * x + c;
                int px = i;
                int py = (int)((yMax - y) / (yMax - yMin) * h);
                Point p = new Point(px, py);
                if (prevPoint != null)
                    g.DrawLine(curvePen, prevPoint.Value, p);
                prevPoint = p;
            }

            // Đánh dấu nghiệm thực nếu có
            if (numNghiem > 0)
            {
                Pen markPen = new Pen(Color.Blue, 2);
                Brush markBrush = Brushes.Blue;
                if (numNghiem >= 1)
                {
                    int px = (int)((x1.Value - xMin) / (xMax - xMin) * w);
                    int py = zeroY;
                    g.FillEllipse(markBrush, px - 3, py - 3, 6, 6);
                    g.DrawString($"x={x1.Value:F2}", font, markBrush, px + 2, py - 15);
                }
                if (numNghiem == 2)
                {
                    int px = (int)((x2.Value - xMin) / (xMax - xMin) * w);
                    int py = zeroY;
                    g.FillEllipse(markBrush, px - 3, py - 3, 6, 6);
                    g.DrawString($"x={x2.Value:F2}", font, markBrush, px + 2, py - 15);
                }
            }

            // --- Vẽ ô ghi chú hàm y = ax^2 + bx + c ---
            string funcText = $"y = {a}x² + {b}x + {c}";
            Font funcFont = new Font("Arial", 10, FontStyle.Bold);
            SizeF textSize = g.MeasureString(funcText, funcFont);
            int margin = 5;
            Rectangle rect = new Rectangle(margin, margin, (int)textSize.Width + 10, (int)textSize.Height + 6);
            g.FillRectangle(Brushes.LightYellow, rect);
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString(funcText, funcFont, Brushes.Black, rect.X + 5, rect.Y + 3);
        }

        return bmp;
    }
}
