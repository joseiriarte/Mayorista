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
        private DireccionCliente domicilio;
        private bool esEdicion;
        private bool esEliminacion;

        public FrmDetalleDomicilio(int idCliente, string nombreCliente)
        {
            InitializeComponent();
            servicio = new MayoristaServicio();

            this.idCliente = idCliente;
            txtDomCliente.Text = nombreCliente;
            esEdicion = false;
        }

        public FrmDetalleDomicilio(DireccionCliente domicilio, string nombreCliente)
        {
            InitializeComponent();
            servicio = new MayoristaServicio();

            this.domicilio = domicilio;
            txtDomCliente.Text= nombreCliente;
            esEdicion = true;
        }

        private void FrmDetalleDomicilio_Load(object sender, EventArgs e)
        {
            CargarCombo();
            txtDomCliente.Enabled = false;

            if (domicilio != null)
            {
                foreach (Barrio b in cboBarrio.Items)
                {
                    if (b.IdBarrio == domicilio.Barrio.IdBarrio)
                    {
                        cboBarrio.SelectedItem = b;
                        break;
                    }
                }
                txtDireccion.Text = domicilio.Direccion;
                txtCP.Text = domicilio.CodigoPostal;
            }
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
                if(!esEdicion)
                {
                    domicilio = new DireccionCliente();
                    domicilio.IdCliente = idCliente;
                }
                
                domicilio.Barrio = (Barrio)cboBarrio.SelectedItem;
                domicilio.Direccion = txtDireccion.Text;
                domicilio.CodigoPostal = txtCP.Text;

                if(esEdicion)
                {
                    if (servicio.EditarDomicilio(domicilio))
                        MessageBox.Show("Domicilio actualizado.");
                }
                else
                {
                    if (servicio.GuardarDomicilio(domicilio))
                        MessageBox.Show("Domicilio registrado.");
                }
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

        private void btnCancelarDom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
