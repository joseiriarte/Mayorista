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
    public partial class FrmDetalleCliente : Form
    {
        MayoristaServicio servicio;
        public FrmDetalleCliente()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
        }

        private void FrmDetalleCliente_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            cboTipoDoc.Items.Clear();
            cboTipoDoc.DataSource = servicio.TraerTiposDoc();
            cboTipoDoc.SelectedIndex = -1;
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                Cliente c = new Cliente();
                c.Id_tipo_documento = (TipoDoc)cboTipoDoc.SelectedItem;
                c.Nro_documento = txtNroDoc.Text;
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.Email = txtEmail.Text;
                c.Telefono = txtTelefono.Text;

                if (servicio.GuardarCliente(c))
                    MessageBox.Show("Cliente registrado.");
                this.Dispose();
            }
        }

        private bool Validar()
        {
            if(cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.");
                return false;
            }
            if(string.IsNullOrEmpty(txtNroDoc.Text))
            {
                MessageBox.Show("Ingrese un numero de documento.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Ingrese un email.");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese un numero de teléfono.");
                return false;
            }
            return true;
        }
    }
}
