namespace Ejercicio1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Tarjeta nueva;
        Persona humano;
        static int numero = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int dni = Convert.ToInt32(textBox2.Text);
            nueva = new Tarjeta(numero++, nombre, dni);
            nueva.Saldo = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(textBox3.Text);
            if (nueva.CargarJuego(monto)) 
            {
                MessageBox(nueva.Dueño.Datos());
            }
        }
    }
}
