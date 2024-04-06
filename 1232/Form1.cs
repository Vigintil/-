using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1232.Classes;

namespace _1232
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.a = int.Parse(textBox1.Text);
                Class1.b = int.Parse(textBox2.Text);
                Class1.c = int.Parse(textBox3.Text);
                int[] abc = Class1.Calc();
                button1.Text = "Calc";
                textBox4.Text = $"{abc[0]}, {abc[1]}, {abc[2]}";
            }
            catch (Exception ex)
            {
                textBox4.Text = "Лох";
                button1.Text = $"{ex}";
            }
        }
    }
}
