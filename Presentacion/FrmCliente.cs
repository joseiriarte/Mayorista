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
    public partial class FrmCliente : Form
    {
        MayoristaServicio servicio;
        public FrmCliente()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            dgvDomicilios.Rows.Clear();

            List<Cliente> lista = new List<Cliente>();

            string filtro = string.Empty;
            if(!string.IsNullOrEmpty(txtCliente.Text))
                filtro = txtCliente.Text;

            lista = servicio.TraerClientes(filtro);

            foreach (Cliente c in lista)
            {
                dgvClientes.Rows.Add(c.Id_cliente, c.Nombre, c.Apellido, c.Telefono);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
                return;

            int idCliente = Convert.ToInt32(
                dgvClientes.CurrentRow.Cells["ColumnNumero"].Value);

            List<DireccionCliente> lista = servicio.TraerDomicilios(idCliente);

            dgvDomicilios.Rows.Clear();

            foreach (DireccionCliente d in lista)
            {
                dgvDomicilios.Rows.Add(d.Direccion, d.Codigo_postal);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar al menú principal?", "Regresando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevoCl_Click(object sender, EventArgs e)
        {
            FrmDetalleCliente fdc = new FrmDetalleCliente();
            fdc.ShowDialog();
        }

        private void btnNuevoDom_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para agregar un domicilio.");
                return;
            }
                
            //Capturar id y nombre del cliente para agregar un domicilio
            int idCliente = (int)dgvClientes.CurrentRow.Cells["ColumnNumero"].Value;
            string nombre = (string)dgvClientes.CurrentRow.Cells["ColumnNombre"].Value;
            string apellido = (string)dgvClientes.CurrentRow.Cells["ColumnApellido"].Value;

            FrmDetalleDomicilio fdd = new FrmDetalleDomicilio(idCliente, $"{nombre} {apellido}");
            fdd.ShowDialog();
        }

        private void btnEditarCl_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para editarlo.");
                return;
            }

            //Capturar cliente
            int id = (int)dgvClientes.CurrentRow.Cells["ColumnNumero"].Value;

            Cliente c = servicio.TraerClientePorId(id);

            FrmDetalleCliente fdc = new FrmDetalleCliente(c);
            fdc.ShowDialog();
        }
    }
}
