using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            //boton siete
            txtDisplay.Text = txtDisplay.Text +"7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton ocho
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton nueve
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton mas
            operacion = 1;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            //boton uno
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            //boton dos
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            //boton tres
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            //boton cuatro
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            //boton cinco
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            //boton seis
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            //boton  menos
            operacion = 2;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";


             

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            //boton multiplicar
            operacion = 3;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }   

        private void btndividir_Click(object sender, EventArgs e)
        {
            //boton dividir
            operacion = 4;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //boton c
            txtDisplay.Text = "";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            //boton punto
            txtDisplay.Text = txtDisplay.Text + ".";

        }

        private void btncero_Click(object sender, EventArgs e)
        {
            //boton cero
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            //boton igual

            valor2 = Convert.ToDouble(txtDisplay.Text);
            
            switch(operacion)
            { 
                case 1:
                    resultado = valor1 + valor2;
                break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                     break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }

            txtDisplay.Text = resultado.ToString();


            
        }
    }
}
