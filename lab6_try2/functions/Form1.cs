using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace functions
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public double c;
        public double x;
        public double xMarked;
        public double y;
        public double start;
        public double end;
        public double step = 0.1;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false)
            {
                MessageBox.Show("График не выбран");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Введены не все значения");
                return;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                x = Convert.ToDouble(textBox4.Text);
                start = Convert.ToDouble(textBox5.Text);
                end = Convert.ToDouble(textBox6.Text);
            }
            if (radioButton1.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = x * a + b;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x,2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton2.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = a * Math.Sin(x*b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton3.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = a * Math.Cos(x * b + c);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton4.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = a * Math.Tan(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton5.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = a * (1 / (Math.Tan(x * b + c)));
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton6.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = b * Math.Pow(x, a);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton7.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = Math.Pow(a, x + b);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
            if (radioButton8.Checked)
            {
                xMarked = x;
                x = start;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= end)
                {
                    y = Math.Pow(((Math.Sin(x) + a * x)/((x - Math.Pow(x,0.5)) + 1)),b/x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (xMarked == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(xMarked, y);
                    }
                    x = x + step;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
