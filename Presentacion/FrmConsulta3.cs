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
    public partial class FrmConsulta3 : Form
    {
        MayoristaServicio servicio;
        public FrmConsulta3()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
        }

        private void btnSalirCon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCon3_Click(object sender, EventArgs e)
        {
            dgvConsultas3.Rows.Clear();

            List <RubroConsulta> listaR = new List<RubroConsulta>();

            listaR = servicio.TraerConsulta3();

            CultureInfo formatoPeso = new CultureInfo("es-AR");

            foreach (RubroConsulta r in listaR)
            {
                dgvConsultas3.Rows.Add(r.Rubro, r.CantidadArticulosVendidos, r.ImporteTotalFacturado.ToString("C2", formatoPeso));
            }
        }
    }
}
