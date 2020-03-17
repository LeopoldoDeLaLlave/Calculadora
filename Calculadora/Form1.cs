using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        Double operando1=0;

        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text=="0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text += boton.Text;
            }
            
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            operacion = boton.Text;

            operando1 = Convert.ToDouble(label1.Text);

            label1.Text = "0";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operacion=="+")
            {
                operando1 += Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
            }else if(operacion == "-")
            {
                operando1 -= Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
            }
            else if (operacion == "*")
            {
                operando1 *= Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
            }
            else if (operacion == "/")
            {
                operando1 /= Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
            }
        }
    }
}
