using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterpolacionWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInterpolar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los puntos ingresados por el usuario
                string[] puntosStr = tbPuntos.Text.Split(',');
                List<double> x = new List<double>();
                List<double> y = new List<double>();

                for (int i = 0; i < puntosStr.Length; i++)
                {
                    string[] punto = puntosStr[i].Split(';');
                    x.Add(double.Parse(punto[0]));
                    y.Add(double.Parse(punto[1]));
                }

                // Obtener el valor para interpolar
                double valorInterpolar = double.Parse(tbValorInterpolar.Text);

                // Realizar la interpolación de Lagrange
                double resultado = InterpolacionLagrange(x.ToArray(), y.ToArray(), valorInterpolar);

                // Mostrar el resultado
                tbResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double InterpolacionLagrange(double[] x, double[] y, double valor)
        {
            double resultado = 0;

            for (int i = 0; i < x.Length; i++)
            {
                double termino = y[i];

                for (int j = 0; j < x.Length; j++)
                {
                    if (j != i)
                    {
                        termino *= (valor - x[j]) / (x[i] - x[j]);
                    }
                }

                resultado += termino;
            }

            return resultado;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
