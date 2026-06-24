using Mayorista.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayorista
{
    public partial class FrmMayorista : Form
    {
        public FrmMayorista()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea salir de la aplicación?","SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) { this.Close(); }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente Fc = new FrmCliente();
            Fc.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntegrantes Fi = new FrmIntegrantes();
            Fi.ShowDialog();
        }
    }
}
