using actividad1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace actividad1
{
    public partial class FormAgregarValor : Form
    {
        Controlador controlador = new Controlador();
        public FormAgregarValor()
        {
            InitializeComponent();
        }

        private void btAgregarValor_Click(object sender, EventArgs e)
        {
            FormAgregarValor ventana = new FormAgregarValor();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(ventana.tbValor.Text);
                controlador.IngresarValor(valor);
            }

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
