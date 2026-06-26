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
        private Cliente cliente;
        private bool esEdicion;
        private bool esEliminacion;

        public FrmDetalleCliente()
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
            esEdicion = false;
        }

        public FrmDetalleCliente(Cliente c)
        {
            InitializeComponent();
            servicio = new MayoristaServicio();
            this.cliente = c;
            esEdicion = true;
        }

        private void FrmDetalleCliente_Load(object sender, EventArgs e)
        {
            CargarCombo();

            if( cliente != null )
            {
                foreach (TipoDoc tipo in cboTipoDoc.Items)
                {
                    if (tipo.Id_tipo_documento == cliente.Id_tipo_documento.Id_tipo_documento)
                    {
                        cboTipoDoc.SelectedItem = tipo;
                        break;
                    }
                }
                txtNroDoc.Text = cliente.Nro_documento;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
            }
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
                if(!esEdicion)
                {
                    cliente = new Cliente();
                }
                cliente.Id_tipo_documento = (TipoDoc)cboTipoDoc.SelectedItem;
                cliente.Nro_documento = txtNroDoc.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefono = txtTelefono.Text;

                if(esEdicion)
                {
                    if (servicio.EditarCliente(cliente))
                    MessageBox.Show("Cliente actualizado");
                }
                else
                {
                    if (servicio.GuardarCliente(cliente))
                        MessageBox.Show("Cliente registrado.");
                }
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

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
