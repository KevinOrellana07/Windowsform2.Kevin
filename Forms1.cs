using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios
{
    public partial class txtInteres : Form
    {
        public txtInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double inversionInicial = double.Parse(txtInversionInicial.Text);
                double tasaInteresAnual = 0.12;
                int periodoInversionAnos = int.Parse(txtPeriodoInversion.Text);

                double capitalFinal = inversionInicial * Math.Pow(1 + tasaInteresAnual, periodoInversionAnos);
                double interesesTotales = capitalFinal - inversionInicial;

                lblCapitalFinal.Text = $"Capital Final: {capitalFinal:C2}";
                lblInteresesTotales.Text = $"Intereses Totales: {interesesTotales:C2}";

                MessageBox.Show($"Intereses Totales: {interesesTotales:C2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
