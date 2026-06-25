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

            //List<DireccionCliente> listaD = new List<DireccionCliente>();
            //if (!string.IsNullOrEmpty(txtCliente.Text))
            //    filtro = txtCliente.Text;
            //listaD = servicio.TraerDomicilios(filtro);

            //foreach (DireccionCliente d in listaD)
            //{
            //    dgvDomicilios.Rows.Add(d.Codigo_postal, d.Direccion);
            //}
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar al menú principal?", "Regresando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
