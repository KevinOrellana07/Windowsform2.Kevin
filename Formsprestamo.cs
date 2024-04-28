using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidadPrestamo = double.Parse(txtCantidadPrestamo.Text);
                double tasaInteresMes = double.Parse(txtTasaInteresMes.Text) / 100;
                int duracionMeses = int.Parse(txtDuracionMeses.Text);

                double cuotaMensual = (cantidadPrestamo * tasaInteresMes) / (1 - Math.Pow(1 + tasaInteresMes, -duracionMeses));

                lblCuotaMensual.Text = $"Cuota Mensual: {cuotaMensual:C2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

