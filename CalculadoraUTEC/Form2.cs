using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraUTEC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = num1 + num2;
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString("0.##"), "Resultado");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = num1 - num2;
            MessageBox.Show("El resultado de la resta es: " + resultado.ToString("0.##"), "Resultado");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = num1 * num2;
            MessageBox.Show("El resultado de la multiplicación es: " + resultado.ToString("0.##"), "Resultado");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                MessageBox.Show("El resultado de la división es: " + resultado.ToString("0.##"), "Resultado");
            }
            else
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarCalculadora_Click(object sender, EventArgs e)
        {
            Form1 calculadoraAvanzada = new Form1();
            calculadoraAvanzada.StartPosition = FormStartPosition.Manual;
            calculadoraAvanzada.Location = this.Location;
            calculadoraAvanzada.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
    }
}
