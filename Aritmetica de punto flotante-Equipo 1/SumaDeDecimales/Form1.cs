using System.Globalization;

namespace SumaDeDecimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Leer los números ingresados por el usuario
                    decimal numero1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                    decimal numero2 = decimal.Parse(textBox2.Text, CultureInfo.InvariantCulture);

                    // Calcular la suma sin redondear
                    decimal resta = numero1 - numero2;

                    // Mostrar la suma en el cuadro de texto de resultado sin redondear
                    textBox3.Text = resta.ToString("0.#############################", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese números decimales válidos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}