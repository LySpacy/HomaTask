
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Уравнения
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox12.Text = "0";
            textBox11.Text = "100";
            textBox10.Text = "-50";
            textBox9.Text = "100";
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
            chart1.Series.Clear(); chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            Series series = new Series();
            Series series1 = new Series();
            Series series2 = new Series();

            series.ChartType = SeriesChartType.Spline;
            series.Points.Clear();

            series1.ChartType = SeriesChartType.Spline;
            series1.Points.Clear();
            series.BorderWidth = 2;

            series2.ChartType = SeriesChartType.Spline;
            series2.Points.Clear();

            var xmin = Double.Parse(textBox12.Text); 
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
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Black;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Black;
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();

            double g = 9.8, mass = 80;

            var step = Double.Parse(textBox3.Text);
            var time = Double.Parse(textBox5.Text);

            double y = 3000;
            double acceleration = 0;
            double speed = 1;

            var k0 = 0.5 * 1.2 * 0.95 * 0.3;
            var k1 = 0.5 * 1.2 * 0.95 * 60;
            double timex = 0, kt = 0;

            while (y >= 0)
            {
                series.Points.AddXY(timex, -acceleration);
                series1.Points.AddXY(timex, -speed);
                series2.Points.AddXY(timex, y / 30);
                y += speed * step;
                if (timex < time)
                {
                    acceleration = -g + k0 * speed * speed / mass;
                    speed = speed - (g - k0 * speed * speed / mass) * step;

                }
                else if ((time < timex) && (timex <= time + 1))
                {
                    kt = k0 + (k1 - k0) * (timex - time);
                   
                    speed = speed - (g - kt * speed * speed / mass) * step;
                    acceleration = -g + kt * speed * speed / mass;
                }
                else
                {
                    acceleration = -g + k1 * speed * speed / mass;
                    speed = speed - (g - k1 * speed * speed / mass) * step;
                }
                timex += step;
            }

            chart1.Series.Add(series);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
       
        }
       
    }
}
