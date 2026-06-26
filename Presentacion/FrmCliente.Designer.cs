namespace Mayorista.Presentacion
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDom = new System.Windows.Forms.Button();
            this.btnEditarDom = new System.Windows.Forms.Button();
            this.btnNuevoDom = new System.Windows.Forms.Button();
            this.btnEliminarCl = new System.Windows.Forms.Button();
            this.btnEditarCl = new System.Windows.Forms.Button();
            this.btnNuevoCl = new System.Windows.Forms.Button();
            this.lblDomicilios = new System.Windows.Forms.Label();
            this.dgvDomicilios = new System.Windows.Forms.DataGridView();
            this.ColumnCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnEliminarDom);
            this.gbCliente.Controls.Add(this.btnEditarDom);
            this.gbCliente.Controls.Add(this.btnNuevoDom);
            this.gbCliente.Controls.Add(this.btnEliminarCl);
            this.gbCliente.Controls.Add(this.btnEditarCl);
            this.gbCliente.Controls.Add(this.btnNuevoCl);
            this.gbCliente.Controls.Add(this.lblDomicilios);
            this.gbCliente.Controls.Add(this.dgvDomicilios);
            this.gbCliente.Controls.Add(this.dgvClientes);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Controls.Add(this.lblCliente);
            this.gbCliente.Location = new System.Drawing.Point(60, 65);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(533, 570);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            // 
            // btnEliminarDom
            // 
            this.btnEliminarDom.Location = new System.Drawing.Point(192, 477);
            this.btnEliminarDom.Name = "btnEliminarDom";
            this.btnEliminarDom.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDom.TabIndex = 10;
            this.btnEliminarDom.Text = "Eliminar";
            this.btnEliminarDom.UseVisualStyleBackColor = true;
            // 
            // btnEditarDom
            // 
            this.btnEditarDom.Location = new System.Drawing.Point(111, 477);
            this.btnEditarDom.Name = "btnEditarDom";
            this.btnEditarDom.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDom.TabIndex = 9;
            this.btnEditarDom.Text = "Editar";
            this.btnEditarDom.UseVisualStyleBackColor = true;
            // 
            // btnNuevoDom
            // 
            this.btnNuevoDom.Location = new System.Drawing.Point(30, 477);
            this.btnNuevoDom.Name = "btnNuevoDom";
            this.btnNuevoDom.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoDom.TabIndex = 1;
            this.btnNuevoDom.Text = "Nuevo";
            this.btnNuevoDom.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCl
            // 
            this.btnEliminarCl.Location = new System.Drawing.Point(192, 242);
            this.btnEliminarCl.Name = "btnEliminarCl";
            this.btnEliminarCl.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCl.TabIndex = 8;
            this.btnEliminarCl.Text = "Eliminar";
            this.btnEliminarCl.UseVisualStyleBackColor = true;
            // 
            // btnEditarCl
            // 
            this.btnEditarCl.Location = new System.Drawing.Point(111, 242);
            this.btnEditarCl.Name = "btnEditarCl";
            this.btnEditarCl.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCl.TabIndex = 7;
            this.btnEditarCl.Text = "Editar";
            this.btnEditarCl.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCl
            // 
            this.btnNuevoCl.Location = new System.Drawing.Point(30, 242);
            this.btnNuevoCl.Name = "btnNuevoCl";
            this.btnNuevoCl.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCl.TabIndex = 6;
            this.btnNuevoCl.Text = "Nuevo";
            this.btnNuevoCl.UseVisualStyleBackColor = true;
            this.btnNuevoCl.Click += new System.EventHandler(this.btnNuevoCl_Click);
            // 
            // lblDomicilios
            // 
            this.lblDomicilios.AutoSize = true;
            this.lblDomicilios.Location = new System.Drawing.Point(30, 287);
            this.lblDomicilios.Name = "lblDomicilios";
            this.lblDomicilios.Size = new System.Drawing.Size(54, 13);
            this.lblDomicilios.TabIndex = 5;
            this.lblDomicilios.Text = "Domicilios";
            // 
            // dgvDomicilios
            // 
            this.dgvDomicilios.AllowUserToAddRows = false;
            this.dgvDomicilios.AllowUserToDeleteRows = false;
            this.dgvDomicilios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCP,
            this.ColumnDireccion});
            this.dgvDomicilios.Location = new System.Drawing.Point(30, 321);
            this.dgvDomicilios.Name = "dgvDomicilios";
            this.dgvDomicilios.ReadOnly = true;
            this.dgvDomicilios.Size = new System.Drawing.Size(464, 150);
            this.dgvDomicilios.TabIndex = 4;
            // 
            // ColumnCP
            // 
            this.ColumnCP.HeaderText = "Código Postal";
            this.ColumnCP.Name = "ColumnCP";
            this.ColumnCP.ReadOnly = true;
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Dirección";
            this.ColumnDireccion.Name = "ColumnDireccion";
            this.ColumnDireccion.ReadOnly = true;
            this.ColumnDireccion.Width = 300;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumero,
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnTelefono});
            this.dgvClientes.Location = new System.Drawing.Point(30, 86);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(464, 150);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Número";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            this.ColumnNumero.Width = 50;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.Name = "ColumnApellido";
            this.ColumnApellido.ReadOnly = true;
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Teléfono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            this.ColumnTelefono.ReadOnly = true;
            this.ColumnTelefono.Width = 150;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(365, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(129, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(146, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(213, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(113, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente / Razón Social";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 658);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "<< Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(661, 693);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvDomicilios;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblDomicilios;
        private System.Windows.Forms.Button btnEliminarDom;
        private System.Windows.Forms.Button btnEditarDom;
        private System.Windows.Forms.Button btnNuevoDom;
        private System.Windows.Forms.Button btnEliminarCl;
        private System.Windows.Forms.Button btnEditarCl;
        private System.Windows.Forms.Button btnNuevoCl;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
    }
}