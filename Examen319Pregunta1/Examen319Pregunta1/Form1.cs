using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen319Pregunta1
{
    public partial class Form1 : Form
    {
        bool sigue=true;
        string operacion;
        double numero1;
        double solucion;
        double numero2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (((Button)sender).Text == "0")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "0";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
                //textBox1.Text = textBox1.Text + "1";
            }

            
            if (((Button)sender).Text == "1") {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "1";
                    sigue = false;
                }
                else 
                {
                    textBox1.Text = textBox1.Text + "1";
                }
                //textBox1.Text = textBox1.Text + "1";
            }
            if (((Button)sender).Text == "2")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "2";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
            if (((Button)sender).Text == "3")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "3";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
            if (((Button)sender).Text == "4")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "4";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
            if (((Button)sender).Text == "5")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "5";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
            if (((Button)sender).Text == "6")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "6";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
            if (((Button)sender).Text == "7")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "7";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
            if (((Button)sender).Text == "8")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "8";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
            if (((Button)sender).Text == "9")
            {
                if (sigue)
                {
                    textBox1.Text = "";
                    textBox1.Text = "9";
                    sigue = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }



        }

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            sigue = true;
            numero1 = double.Parse(textBox1.Text);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            sigue = true;
            numero1 = double.Parse(textBox1.Text);
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            sigue = true;
            numero1 = double.Parse(textBox1.Text);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            sigue = true;
            numero1 = double.Parse(textBox1.Text);
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(textBox1.Text);
            sigue = true;

            switch (operacion) 
            { 
                case "+":
                    solucion = numero1 + numero2;
                    textBox1.Text = solucion.ToString();
                    break;
                case "-":
                    solucion = numero1 - numero2;
                    textBox1.Text = solucion.ToString();
                    break;
                case "*":
                    solucion = numero1 * numero2;
                    textBox1.Text = solucion.ToString();
                    break;
                case "/":
                    solucion = numero1 / numero2;
                    textBox1.Text = solucion.ToString();
                    break;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sigue =true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }



 


    }
}
