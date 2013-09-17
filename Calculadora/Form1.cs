using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal val1, val2, resultado;
        string operador;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            operador = "suma";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            if (operador =="suma")
                
            {
                resultado = val1+val2;
            }

            if (operador == "resta")
            {
                resultado = val1 - val2;
            } 
            if (operador == "multi")
            {
                resultado = val1 * val2;
            } 
            if (operador == "division")
            {
                resultado = val1 / val2;
            }

            textBox1.Text = Convert.ToString(resultado);


        }

        private void button13_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            operador = "resta";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            val1 = 0;
            val2 = 0;
            resultado = 0;
            operador = null;

        }
<<<<<<< HEAD

        private void button15_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            operador = "division";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            operador = "multi";
        }
=======
>>>>>>> empezando =D
    }
}
