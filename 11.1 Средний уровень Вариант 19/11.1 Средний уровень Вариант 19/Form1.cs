﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._1_Средний_уровень_Вариант_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass vector = new MyClass();
            vector.x1 = int.Parse(Edit1.Text);
            vector.y1 = int.Parse(Edit2.Text);
            vector.x2 = int.Parse(Edit3.Text);
            vector.y2 = int.Parse(Edit4.Text);
            Memo1.Text = vector.V2()[0].ToString();
            Memo2.Text = vector.V2()[1].ToString();
            Memo3.Text = vector.S().ToString();
        }
    }
}
