using System;
using System.Data;
using System.Windows.Forms;
using NCalc;
namespace ReglaDelRectangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string funcion = textBox1.Text;

            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            int n = Convert.ToInt32(textBox4.Text);

            double integral = Integrar(funcion, a, b, n);

            textBox5.Text = integral.ToString();
        }
        public double Integrar(string funcion, double a, double b, int n)
        {
            double h = (b - a) / n;

            double integral = 0;
            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * h;

                double area = EvaluarFuncion(funcion, x) * h;

                integral += area;
            }

            return integral;
        }
        private double EvaluarFuncion(string funcion, double x)
        {
            try
            {
                return Math.Pow(x, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la función: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}