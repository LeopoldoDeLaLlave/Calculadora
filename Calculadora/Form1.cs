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
        Boolean operaciones = true;//Nos indica si hay un solo operador
        Boolean igual = false;//indica si se acaba de pulsar igual para poder introducir un nuevo número

        String operacion = "";//Operación que realizaremos
        public Form1()
        {
            InitializeComponent();
        }

        //Números y comas, para mostrar en el label1 y recogerlos
        private void button1_Click(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;



            if (label1.Text=="0"&&boton.Text!=",")
            {
                label1.Text = boton.Text;
            }
            else
            {
                if (igual)//Si el igual acaba de ser pulsado al introducir otro número borramos el que había
                {
                    if (boton.Text == "," )
                    {

                         label1.Text = "0,";
                         igual = false;
                        
                    }
                    else
                    {
                        label1.Text = boton.Text;
                        igual = false;
                    }
                    
                }
                else
                {
                    if (boton.Text == "," && !label1.Text.Contains(","))//Para que solo pueda haber una coma por número
                    {
                        label1.Text += boton.Text;

                    }
                    else if(boton.Text != ",")
                    {
                        label1.Text += boton.Text;
                    }
                    
                }
            }

        }

        //Operaciones
        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            operacion = boton.Text;
            if (operaciones)
            {//Solo se puede haber un operador por operación
                operando1 = Convert.ToDouble(label1.Text);

                label1.Text = "0";
            }
            operaciones = false;
            igual = false;
 

        }

        //Igual, realiza la operación si es posible
        private void button10_Click(object sender, EventArgs e)
        {
            if (operacion=="+")
            {
                operando1 += Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
                igual = true;

            }
            else if(operacion == "-")
            {
                operando1 -= Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
                igual = true;

            }
            else if (operacion == "*")
            {
                operando1 *= Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
                igual = true;

            }
            else if (operacion == "/")
            {
                operando1 /= Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(operando1);
                igual = true;

            }
            else if (operacion == "^")
            {
                operando1 = Math.Pow(operando1, Convert.ToDouble(label1.Text));
                label1.Text = Convert.ToString(operando1);
                igual = true;
     
            }
            else if (operacion == "√")
            {
                operando1 = Convert.ToDouble(label1.Text.Substring(1));
                operando1 = Math.Sqrt(operando1);
                label1.Text = Convert.ToString(operando1);
                igual = true;

            }

            operacion = "";
            operaciones = true;
            
        }

        //Borra el último número introducido
        private void button16_Click(object sender, EventArgs e)
        {

            if (label1.Text.Length==1)//Si ya hay un 0 lo deja
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Substring(0,label1.Text.Length-1);
            }
            
        }

        //Reinicia la calculadora
        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            operando1 = 0;

            operaciones = true;//Nos indica si hay un solo operador
            igual = false;

            operacion = "";

        }

        //Raíces cuadradas
        private void button19_Click(object sender, EventArgs e)
        {

            operando1 = Convert.ToDouble(label1.Text);
            if (label1.Text == "0")//Si solo hay un 0 lo quitamos por estética
            {
                label1.Text = "";
            }
            label1.Text = "√"+ label1.Text;//Ponemos el "√" a principio del texto
            operacion = "√";
            igual = false;

        }

    }
}
