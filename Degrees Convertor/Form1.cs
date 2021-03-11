using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degrees_Convertor
{
    public partial class Form1 : Form
    {
        Degrees degrees = new Degrees();
        double val;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CelToFahr.Checked)
            {
                val = double.Parse(textBox1.Text);
                MessageBox.Show(degrees.CelToFahr(val).ToString()+ " °F");
            }
            else if(FahrToCel.Checked)
            {
                val = double.Parse(textBox1.Text);
                MessageBox.Show(degrees.FahrToCel(val).ToString()+ "°C");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
