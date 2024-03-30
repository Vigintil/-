using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._1.Базовый_уровень_Вариант_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass sqare = new MyClass();
            sqare.x = int.Parse(textX.Text);
            sqare.y = int.Parse(textY.Text);
            Memo.Text = sqare.Perimetr().ToString();
        }
    }
}
