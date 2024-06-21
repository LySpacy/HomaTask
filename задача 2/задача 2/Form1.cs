
using System;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;
using System.Collections.Generic;

namespace Уравнения
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox12.Text = "0";
            textBox11.Text = "10";
            textBox10.Text = "0";
            textBox9.Text = "10";
        }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox1.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox2.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox3.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox6.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox5.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        { }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 45 && textBox9.SelectionStart == 0) {; }
                else
                {
                    if (e.KeyChar == '.') e.KeyChar = ',';
                    if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    {
                        e.Handled = true;
                    }
                }
            }
            private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 45 && textBox10.SelectionStart == 0) {; }
                else
                {
                    if (e.KeyChar == '.') e.KeyChar = ',';
                    if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    {
                        e.Handled = true;
                    }
                }
            }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox11.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && textBox12.SelectionStart == 0) {; }
            else
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
        }
           

        private void button3_Click(object sender, EventArgs e)
        {

            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            chart1.Visible = true;

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            double xmin = 0;
            double xmax = Convert.ToDouble(textBox11.Text);
            double ymin = Convert.ToDouble(textBox10.Text);
            double ymax = Convert.ToDouble(textBox9.Text);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;
            chart1.ChartAreas[0].AxisY.Minimum = ymin;
            chart1.ChartAreas[0].AxisY.Maximum = ymax;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 5;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 5;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();

            var step = Double.Parse(textBox3.Text);
            var v = Double.Parse(textBox1.Text);
            var f = Double.Parse(textBox2.Text); 
            var c = Double.Parse(textBox5.Text);
            var m = Double.Parse(textBox6.Text);
            double max = 0, maxf=0;


            Series series = new Series();
            Series series1 = new Series();

            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 2;

            series1.ChartType = SeriesChartType.Spline;
            series1.Points.Clear();

            series.Points.Clear();

            var k = (f * Math.PI) / 180;
            double x = 0, y = 0;
            var vx = v * Math.Cos(k);
            var vy = v * Math.Sin(k);

            double xt=0, yt=0;
            double t = 0;
            while (y >= 0)
            {
                series.Points.AddXY(x, y);
                series1.Points.AddXY(xt, yt);
                x = x + step * vx;
                y = y + step * vy;
                vx = vx - (step * c * vx) / m;
                vy = vy - step * (9.8 + (c * vy) / m);
                t += step;
                xt = (m / c) * v * Math.Cos(k) * (1 - Math.Exp(-c * t / m));
                yt = (m / c) * (v * Math.Sin(k) + (m * 9.8 / c)) * (1 - Math.Exp(-c * t / m)) - (m * 9.8 * t) / c;
            }

            if (max < x)
            {
                max = x;
                maxf = f;
            }
                
            chart1.Series.Add(series);
            chart1.Series.Add(series1);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
