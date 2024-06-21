
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
        private List<Point> pointsList = new List<Point>();

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < pointsList.Count - 1; i++)
            {
                if (pointsList[i].Y > pointsList[i + 1].Y)
                {
                    textBox4.Text = "Макимальная высота: " + pointsList[i].Y.ToString("N3") + Environment.NewLine;
                }
            }
            textBox4.Text += "Расстояние: " + pointsList[pointsList.Count - 1].X.ToString("N3") + Environment.NewLine;

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

            chart1.Series.Clear(); chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            Series series = new Series();
            Series series1 = new Series();

            series.ChartType = SeriesChartType.Spline;
            series.Points.Clear();

            series1.ChartType = SeriesChartType.Spline;
            series1.Points.Clear();

            series.BorderWidth = 2;

            double xmin = 0;
            var xmax = Double.Parse(textBox11.Text);
            var ymin = Double.Parse(textBox10.Text);
            var ymax = Double.Parse(textBox9.Text);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax; ;
            chart1.ChartAreas[0].AxisY.Minimum = ymin; ;
            chart1.ChartAreas[0].AxisY.Maximum = ymax; ;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 5;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 5;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();

            var step = Double.Parse(textBox3.Text);
            var speed = Double.Parse(textBox1.Text);
            var angle = Double.Parse(textBox2.Text);
            angle = (angle * Math.PI) / 180;

            double x = 0;
            double y = 0;

            var speedx = speed * Math.Cos(angle);
            var speedy = speed * Math.Sin(angle);

            while (y >= 0)
            {
                pointsList.Add(new Point(x, y));
                series.Points.AddXY(x, y);
                x = speedx * step + x;
                y = speedy * step + y;
                speedy = -9.8 * step + speedy;

            }

            chart1.Series.Add(series);

            var length = ((speed * speed) / 9.8) * Math.Sin(2 * angle);

            for (x = 0; x <= length; x+=step)
            {
                pointsList.Add(new Point(x, y));
                series1.Points.AddXY(x, y);
                y = x * Math.Tan(angle) - Math.Pow(x, 2) * (9.8/(2*Math.Pow(speed,2)*Math.Pow(Math.Cos(angle),2)));
            }
            chart1.Series.Add(series1);
        }
        
    }
}
