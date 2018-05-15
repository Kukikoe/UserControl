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
    public partial class FullIndicator : UserControl
    {
        public enum IndicatorMode
        {
            Left, Right, Full
        }
        private float[] _sin = new float[360];
        private float[] _cos = new float[360];
        Color color = Color.Black;
        public int _value = 0;
        private int _max_value = 100;

        [Browsable(true)]
        public IndicatorMode Indicator { get; set; } = IndicatorMode.Full;

        public FullIndicator()
        {
            InitializeComponent();
            for (int i = 0; i < 360; ++i)
            {
                _sin[i] = (float)Math.Sin(i * Math.PI / 180.0F);
                _cos[i] = (float)Math.Cos(i * Math.PI / 180.0F);
            }
        }

        private void FullIndicator_Paint(object sender, PaintEventArgs e)
        {
            if (Indicator == IndicatorMode.Full)
            {
                FullIndicatorPaint(e);
            }
            else if (Indicator == IndicatorMode.Left)
            {
                LeftIndicatorPaint(e);
            }
            else
            {
                RightIndicatorPaint(e);
            }
        }
        private void FullIndicatorPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            PointF centerPoint = new PointF(ClientSize.Width / 2.0F, ClientSize.Height - 1);
            float radius = ClientSize.Width > ClientSize.Height * 2 ? ClientSize.Height : ClientSize.Width / 2;
            for (int i = 0; i < 100; i += 10)
            {
                float angle = 180F * (i / 100F) + 180F;
                float r = radius;
                PointF point1 = new PointF(centerPoint.X + (r - (r * 0.03F)) * _cos[(int)angle % 360], centerPoint.Y + (r - (r * 0.03F)) * _sin[(int)angle % 360]);
                PointF point2 = new PointF(centerPoint.X + (r - (r * 0.1F)) * _cos[(int)angle % 360], centerPoint.Y + (r - (r * 0.1F)) * _sin[(int)angle % 360]);
                gr.DrawLine(new Pen(Color.Red, 3), point1, point2);
            }
            float angle_arrow = 180F * (_value / 100F) + 180F;
            PointF endPoint = new PointF(centerPoint.X + (radius - 30) * _cos[(int)angle_arrow % 360], centerPoint.Y + (radius - 30) * _sin[(int)angle_arrow % 360]);
            gr.DrawLine(new Pen(Color.Black, 2), centerPoint, endPoint);
            gr.FillEllipse(Brushes.Black, centerPoint.X - 10, centerPoint.Y - 10, 20, 20);
            gr.DrawEllipse(new Pen(Color.Red, 3), centerPoint.X - radius, centerPoint.Y - radius, radius * 2, radius * 2);
        }
        private void RightIndicatorPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            PointF centerPoint = new PointF(1, ClientSize.Height - 1);
            float radius = ClientSize.Width > ClientSize.Height * 2 ? ClientSize.Height : ClientSize.Width / 2;
            for (int i = 0; i < 100; i += 10)
            {
                float angle = 90F * (i / 100F) + 180F;
                float r = radius;
                PointF point1 = new PointF(centerPoint.X - (r - (r * 0.03F)) * _cos[(int)angle % 360], centerPoint.Y + (r - (r * 0.03F)) * _sin[(int)angle % 360]);
                PointF point2 = new PointF(centerPoint.X - (r - (r * 0.1F)) * _cos[(int)angle % 360], centerPoint.Y + (r - (r * 0.1F)) * _sin[(int)angle % 360]);
                gr.DrawLine(new Pen(Color.Red, 3), point1, point2);
            }
            float angle_arrow = 90F * (_value / 100F) + 270F;
            PointF endPoint = new PointF(centerPoint.X + (radius - 30) * _cos[(int)angle_arrow % 360], centerPoint.Y + (radius - 30) * _sin[(int)angle_arrow % 360]);
            gr.DrawLine(new Pen(Color.Black, 2), centerPoint, endPoint);
            gr.FillEllipse(Brushes.Black, centerPoint.X - 10, centerPoint.Y - 10, 20, 20);
            gr.DrawEllipse(new Pen(Color.Red, 3), centerPoint.X - radius, centerPoint.Y - radius, radius * 2, radius * 2);
        }

        private void LeftIndicatorPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            PointF centerPoint = new PointF(ClientSize.Width, ClientSize.Height - 1);
            float radius = ClientSize.Width > ClientSize.Height * 2 ? ClientSize.Height : ClientSize.Width / 2;
            for (int i = 0; i < 100; i += 10)
            {
                float angle = 90F * (i / 100F) + 180F;
                float r = radius;
                PointF point1 = new PointF(centerPoint.X + (r - (r * 0.03F)) * _cos[(int)angle % 360], centerPoint.Y + (r - (r * 0.03F)) * _sin[(int)angle % 360]);
                PointF point2 = new PointF(centerPoint.X + (r - (r * 0.1F)) * _cos[(int)angle % 360], centerPoint.Y + (r - (r * 0.1F)) * _sin[(int)angle % 360]);
                gr.DrawLine(new Pen(Color.Red, 3), point1, point2);
            }
            float angle_arrow = 90F * (_value / 100F) + 180F;
            PointF endPoint = new PointF(centerPoint.X + (radius - 30) * _cos[(int)angle_arrow % 360], centerPoint.Y + (radius - 30) * _sin[(int)angle_arrow % 360]);
            gr.DrawLine(new Pen(Color.Black, 2), centerPoint, endPoint);
            gr.FillEllipse(Brushes.Black, centerPoint.X - 10, centerPoint.Y - 10, 20, 20);
            gr.DrawEllipse(new Pen(Color.Red, 3), centerPoint.X - radius, centerPoint.Y - radius, radius * 2, radius * 2);
        }

        private void FullIndicator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _value += 1;
                if (_value == _max_value)
                {
                    _value = 0;
                }
            }
            Invalidate();
        }
    }
}
