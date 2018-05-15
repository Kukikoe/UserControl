using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlClock
{
    public partial class Clock : UserControl
    {
        private float[] _sin = new float[360];
        private float[] _cos = new float[360];
        Color color_sec_arrow = Color.Black;
        Color color_min_arrow = Color.Black;
        Color color_hour_arrow = Color.Black;
        private int TimeZoneUtc = 2;

        public Clock()
        {
            InitializeComponent();
            for (int i = 0; i < 360; ++i)
            {
                _sin[i] = (float)Math.Sin(i * Math.PI / 180.0F);
                _cos[i] = (float)Math.Cos(i * Math.PI / 180.0F);
            }
        }

        private void Clock_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            PointF centerPoint = new PointF(ClientSize.Width / 2.0F, ClientSize.Height / 2.0F);
            float radius = ClientSize.Width > ClientSize.Height ? ClientSize.Height / 2 - 40 : ClientSize.Width / 2 - 40;

            int sec = DateTime.Now.Second * 6 + 270;
            int minute = DateTime.Now.Minute * 6 + 270;
            int hour = (DateTime.Now.Hour - 2 + TimeZoneUtc) * 30 + 270;

            PointF endPoint = new PointF(centerPoint.X + radius * _cos[sec % 360], centerPoint.Y + radius * _sin[sec % 360]);
            PointF endPointMinute = new PointF(centerPoint.X + (radius - 10) * _cos[minute % 360], centerPoint.Y + (radius - 10) * _sin[minute % 360]);
            PointF endPointHour = new PointF(centerPoint.X + (radius / 2) * _cos[hour % 360 + ((minute - 270) % 360) / 12], centerPoint.Y + (radius / 2) * _sin[hour % 360 + ((minute - 270) % 360) / 12]);
            // numbers
            for (int i = 1; i < 13; ++i)
            {
                string dig = i.ToString();
                SizeF sd = gr.MeasureString(dig, this.Font);
                PointF rp = new PointF(centerPoint.X + (radius + 10) * _cos[(i * 30 + 270) % 360] - sd.Width / 2, centerPoint.Y + (radius + 10) * _sin[(i * 30 + 270) % 360] - sd.Height / 2);
                gr.FillEllipse(Brushes.White, (centerPoint.X + (radius + 10) * _cos[(i * 30 + 270) % 360]) - 20, (centerPoint.Y + (radius + 10) * _sin[(i * 30 + 270) % 360]) - 20, 40, 40);
                gr.DrawString(dig, this.Font, new SolidBrush(Color.Black), rp);

            }


            Pen p = new Pen(color_sec_arrow, 2);
            Pen min = new Pen(color_min_arrow, 6);
            Pen hours = new Pen(color_hour_arrow, 10);

            gr.DrawLine(p, centerPoint, endPoint);
            gr.DrawLine(min, centerPoint, endPointMinute);
            gr.DrawLine(hours, centerPoint, endPointHour);
            gr.FillEllipse(Brushes.Black, centerPoint.X - 20 / 2, centerPoint.Y - 20 / 2, 20, 20);
            gr.FillEllipse(Brushes.White, centerPoint.X - 10 / 2, centerPoint.Y - 10 / 2, 10, 10);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch((sender as ToolStripMenuItem).Tag)
            {
                case "second":
                    color_sec_arrow = (sender as ToolStripMenuItem).BackColor;
                    break;
                case "minute":
                    color_min_arrow = (sender as ToolStripMenuItem).BackColor;
                    break;
                case "hour":
                    color_hour_arrow = (sender as ToolStripMenuItem).BackColor;
                    break;
            }
        }

        private void changeTimezoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = Convert.ToInt32((sender as ToolStripMenuItem)?.Tag);
            TimeZoneUtc = 0;
            TimeZoneUtc += b;
            
           
        }
    }
}
