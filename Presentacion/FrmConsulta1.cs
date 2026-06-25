using Mayorista.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayorista.Presentacion
{
    public partial class FrmConsulta1 : Form
    {
        MayoristaServicio servicio;
        public FrmConsulta1()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
        }
        private void btnCon1_Click(object sender, EventArgs e)
        {
            dgvConsultas.Rows.Clear();

            List<Cliente> lista = new List<Cliente>();

            lista = servicio.TraerConsulta1();

            foreach (Cliente c in lista)
            {
                dgvConsultas.Rows.Add(c.Nombre);
            }

        }

        private void btnSalirCon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
