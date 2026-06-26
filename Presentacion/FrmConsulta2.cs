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
    public partial class FrmConsulta2 : Form
    {
        MayoristaServicio servicio;
        public FrmConsulta2()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
        }

        private void btnCon2_Click(object sender, EventArgs e)
        {
            dgvConsultas2.Rows.Clear();
            
            List <FacturaConsulta> listaF = new List<FacturaConsulta>();
            
            listaF = servicio.TraerConsulta2();

            CultureInfo formatoPeso = new CultureInfo("es-AR");

            foreach (FacturaConsulta f in listaF)
            {
                dgvConsultas2.Rows.Add(f.NroFactura, f.FechaFactura, f.Importe.ToString("C2", formatoPeso), f.FormaPago);
            }
        }

        private void btnSalirCon2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
