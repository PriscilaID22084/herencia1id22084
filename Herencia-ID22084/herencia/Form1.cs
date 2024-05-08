using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              
        private void Suma_Click_1(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija suma
            Sumar suma = new Sumar(); // intancie un nuevo objeto suma
            //llenar el metodo de clase suma operar
            textBox3.Text = suma.operar
            (double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            try//intentar crear el objeto división
            {
                //tipo de dato variable, carga de valores en objeto a metodo
                //voy a darle comportamiento a mi boton
                //voy a utilizar mi clase hija suma
                Dividir dividir1 = new Dividir(); // intancie un nuevo objeto suma
                                              //llenar el metodo de clase suma operar
                textBox3.Text = dividir1.operar
                (double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
            }
            catch (ArgumentException ex)// cachar si el if de num2==0 se cumple
            {
                textBox3.Text = (ex.Message); //manda a traer mensaje de muestra if división
            }
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija suma
            Restar resta = new Restar(); // intancie un nuevo objeto suma
            //llenar el metodo de clase suma operar
            textBox3.Text = resta.operar
            (double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija suma
            Multiplicar multi = new Multiplicar(); // intancie un nuevo objeto suma
            //llenar el metodo de clase suma operar
            textBox3.Text = multi.operar
            (double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
