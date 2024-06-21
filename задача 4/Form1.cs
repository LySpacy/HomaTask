
using System;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Design;

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
            textBox4.Text = "";
            double max = 0;

            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            chart1.Visible = true;

            chart1.Series.Clear(); 
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

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
            var maxx = 0.0;
            var d = 0.2;
            var area = Math.PI * Math.Pow(d, 2) / 4;
            var density = 0.0;
            var angle = 0.0;
            var speedX = 0.0;
            var speedY = 0.0;
            var x = 0.0;
            var y = 0.0;
            var speedXSup = 0.0;
            var speedYSup = 0.0;
            var k = 0.5 * 1.2 * 0.2 * area;
            var g = 9.81;
            var mass = 104.0;

            for (int i = 20; i < 50; i++)
            {
                x = 0;
                y = 0;

                Series series = new Series();

                series.Points.Clear();
                series.ChartType = SeriesChartType.Spline;
                series.BorderWidth = 2;
                angle = i * Math.PI / 180;
                speedX = 1800 * Math.Cos(angle);
                speedY = 1800 * Math.Sin(angle);

                while (y >= 0)
                {
                    series.Points.AddXY(x / 1000, y / 50);
                    speedXSup = speedX;
                    speedYSup = speedY;
                    speedX += -k * Math.Sqrt(Math.Pow(speedXSup, 2) + Math.Pow(speedYSup, 2)) * speedXSup / mass * step;
                    speedY += (-g - (k * Math.Sqrt(Math.Pow(speedXSup, 2) + Math.Pow(speedYSup, 2)) * speedYSup) / mass) * step;
                    x += speedX * step;
                    y += speedY * step;
                }

                if (maxx <= x)
                {
                    maxx = x;
                    max = i;
                }
                else
                {
                    chart1.Series.Add(series);
                    break;

                }
              
            }

            textBox4.Text += "не учитывая изменения плотности воздуха: "+ Math.Round (max,3).ToString() +" "+ Math.Round (maxx/1000,3).ToString();

            maxx = 0;
            max = 0;

            for (int i = 20; i < 50; i++)
            {       
                Series series1 = new Series();
                series1.ChartType = SeriesChartType.Spline;
                series1.Points.Clear();
                x = 0; y = 0; k = 0;
                angle = i * Math.PI / 180;
                speedX = 1800 * Math.Cos(angle);
                speedY = 1800 * Math.Sin(angle);

                while (y >= 0)
                {
                   
                    density = 1.2 * Math.Exp(-y / 80000);
                    k = 0.5 * density * 0.2 * area;
                    series1.Points.AddXY(x / 1000, y / 50);
                    speedXSup = speedX;
                    speedYSup = speedY;
                    speedX += -k * Math.Sqrt(Math.Pow(speedXSup, 2) + Math.Pow(speedYSup, 2)) * speedXSup / mass * step;
                    speedY += (-g - (k * Math.Sqrt(Math.Pow(speedXSup, 2) + Math.Pow(speedYSup, 2)) * speedYSup) / mass) * step;
                    x += speedX * step;
                    y += speedY * step;
                }

                if (maxx <= x)
                {
                    maxx = x;
                    max = i;
                }
                else
                { 
                    chart1.Series.Add(series1);
                    break;
                  
                }
            }

            textBox4.Text +=Environment.NewLine+ "учитывая изменения плотности воздуха: " + Math.Round (max,3).ToString() + " " + Math.Round (maxx/1000,3).ToString();

        }  
       

    }
}
