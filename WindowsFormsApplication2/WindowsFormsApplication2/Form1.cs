using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double qwe, asd;
            if (double.TryParse(textBox1.Text, out qwe) && double.TryParse(textBox2.Text, out asd))
            {
                double a = (qwe - asd) / 2;
                double b = a + asd;
                label3.Text = String.Format("Стоимость светодиода: {0};\nСтоимость энергосберегающей лампы: {1}", a, b);
            }
        }
    }
}
