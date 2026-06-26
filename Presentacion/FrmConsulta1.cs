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

            List<ClienteConsulta> lista = new List<ClienteConsulta>();

            lista = servicio.TraerConsulta1();
            
            CultureInfo formatoPeso = new CultureInfo("es-AR");
            // Formato de moneda para Argentina (using System.Globalization; CultureInfo (clase de .NET))
            foreach (ClienteConsulta c in lista)
            {
                dgvConsultas.Rows.Add(c.Nombre + " " + c.Apellido, c.TotalCompras.ToString("C2", formatoPeso), c.PromedioCompras.ToString("C2", formatoPeso), c.CantidadCompras);
            }

        }

        private void btnSalirCon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
