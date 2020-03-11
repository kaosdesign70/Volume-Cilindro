using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Volume_do_Cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double diametro, altura, volume;
            try
            {
                diametro = double.Parse(txtDiametro.Text);
                altura = double.Parse(txtAltura.Text);
                volume = 0.25 * Math.PI * Math.Pow(diametro, 2) * altura * 1000;
                txtVolume.Text = volume.ToString("N2");
            }
            catch/* Serve para tratar erros de inserção*/
            {
                MessageBox.Show("Advertência Cuidado Danger!");
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
