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
    public partial class FrmDetalleDomicilio : Form
    {
        MayoristaServicio servicio;
        private int idCliente;

        public FrmDetalleDomicilio(int idCliente, string nombreCliente)
        {
            InitializeComponent();
            servicio = new MayoristaServicio();

            this.idCliente = idCliente;
            txtDomCliente.Text = nombreCliente;
        }

        private void FrmDetalleDomicilio_Load(object sender, EventArgs e)
        {
            CargarCombo();
            txtDomCliente.Enabled = false;
        }

        private void CargarCombo()
        {
            cboBarrio.Items.Clear();
            cboBarrio.DataSource = servicio.TraerBarrios();
            cboBarrio.SelectedIndex = -1;
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptarDomicilio_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                DireccionCliente d = new DireccionCliente();
                d.Id_cliente = idCliente;
                d.Id_barrio = (Barrio)cboBarrio.SelectedItem;
                d.Direccion = txtDireccion.Text;
                d.Codigo_postal = txtCP.Text;

                if (servicio.GuardarDomicilio(d))
                    MessageBox.Show("Domicilio registrado.");
                this.Dispose();
            }
        }

        private bool Validar()
        {
            if(cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio.");
                return false;
            }
            if(string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar una dirección");
                return false;
            }
            if (string.IsNullOrEmpty(txtCP.Text))
            {
                MessageBox.Show("Debe ingresar un código postal.");
                return false;
            }
            return true;
        }
    }
}
