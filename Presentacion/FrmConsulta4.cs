using Mayorista.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayorista.Presentacion
{
    public partial class FrmConsulta4 : Form
    {
        MayoristaServicio servicio;
        public FrmConsulta4()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
        }

        private void btnSalirCon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCon4_Click(object sender, EventArgs e)
        {
            dgvConsultas4.Rows.Clear();

            List<ClienteConsulta> listaC4 = new List<ClienteConsulta>();

            listaC4 = servicio.TraerConsulta4();

            CultureInfo formatoPeso = new CultureInfo("es-AR");

            foreach (ClienteConsulta c in listaC4)
            {
                dgvConsultas4.Rows.Add(c.Nombre + " " + c.Apellido, c.Barrio, c.CantidadCompras, c.TotalCompras.ToString("C2", formatoPeso));
            }
        }
    }
}
