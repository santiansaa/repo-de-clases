using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente Micliente = new Cliente(30223334441);
        private void button1_Click(object sender, EventArgs e)
        {
            string moneda = "real";
            string tipo = Convert.ToString(textBox1.Text);
            if (radioButton1.Checked)
            {
                moneda = "dolar";
            }
            else if (radioButton2.Checked) 
            {
                moneda = "peso";

            }
            Micliente.CrearCuenta(tipo, moneda);
            foreach (string s in Micliente.ListaDeCuentas()) 
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
