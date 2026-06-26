namespace Mayorista.Presentacion
{
    partial class FrmDetalleDomicilio
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
            this.lblDomCliente = new System.Windows.Forms.Label();
            this.lblDomBarrio = new System.Windows.Forms.Label();
            this.lblDomDireccion = new System.Windows.Forms.Label();
            this.lblDomCP = new System.Windows.Forms.Label();
            this.txtDomCliente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.btnAceptarDomicilio = new System.Windows.Forms.Button();
            this.btnCancelarDom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDomCliente
            // 
            this.lblDomCliente.AutoSize = true;
            this.lblDomCliente.Location = new System.Drawing.Point(39, 53);
            this.lblDomCliente.Name = "lblDomCliente";
            this.lblDomCliente.Size = new System.Drawing.Size(39, 13);
            this.lblDomCliente.TabIndex = 0;
            this.lblDomCliente.Text = "Cliente";
            // 
            // lblDomBarrio
            // 
            this.lblDomBarrio.AutoSize = true;
            this.lblDomBarrio.Location = new System.Drawing.Point(39, 108);
            this.lblDomBarrio.Name = "lblDomBarrio";
            this.lblDomBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblDomBarrio.TabIndex = 1;
            this.lblDomBarrio.Text = "Barrio";
            // 
            // lblDomDireccion
            // 
            this.lblDomDireccion.AutoSize = true;
            this.lblDomDireccion.Location = new System.Drawing.Point(39, 167);
            this.lblDomDireccion.Name = "lblDomDireccion";
            this.lblDomDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDomDireccion.TabIndex = 2;
            this.lblDomDireccion.Text = "Dirección";
            // 
            // lblDomCP
            // 
            this.lblDomCP.AutoSize = true;
            this.lblDomCP.Location = new System.Drawing.Point(39, 223);
            this.lblDomCP.Name = "lblDomCP";
            this.lblDomCP.Size = new System.Drawing.Size(72, 13);
            this.lblDomCP.TabIndex = 3;
            this.lblDomCP.Text = "Código Postal";
            // 
            // txtDomCliente
            // 
            this.txtDomCliente.Location = new System.Drawing.Point(227, 46);
            this.txtDomCliente.Name = "txtDomCliente";
            this.txtDomCliente.Size = new System.Drawing.Size(195, 20);
            this.txtDomCliente.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(227, 160);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(195, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(227, 216);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(84, 20);
            this.txtCP.TabIndex = 6;
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(227, 99);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(195, 21);
            this.cboBarrio.TabIndex = 7;
            // 
            // btnAceptarDomicilio
            // 
            this.btnAceptarDomicilio.Location = new System.Drawing.Point(42, 311);
            this.btnAceptarDomicilio.Name = "btnAceptarDomicilio";
            this.btnAceptarDomicilio.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarDomicilio.TabIndex = 8;
            this.btnAceptarDomicilio.Text = "Aceptar";
            this.btnAceptarDomicilio.UseVisualStyleBackColor = true;
            this.btnAceptarDomicilio.Click += new System.EventHandler(this.btnAceptarDomicilio_Click);
            // 
            // btnCancelarDom
            // 
            this.btnCancelarDom.Location = new System.Drawing.Point(347, 311);
            this.btnCancelarDom.Name = "btnCancelarDom";
            this.btnCancelarDom.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDom.TabIndex = 9;
            this.btnCancelarDom.Text = "Cancelar";
            this.btnCancelarDom.UseVisualStyleBackColor = true;
            // 
            // FrmDetalleDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.btnCancelarDom);
            this.Controls.Add(this.btnAceptarDomicilio);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDomCliente);
            this.Controls.Add(this.lblDomCP);
            this.Controls.Add(this.lblDomDireccion);
            this.Controls.Add(this.lblDomBarrio);
            this.Controls.Add(this.lblDomCliente);
            this.Name = "FrmDetalleDomicilio";
            this.Text = "FrmDetalleDomicilio";
            this.Load += new System.EventHandler(this.FrmDetalleDomicilio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomCliente;
        private System.Windows.Forms.Label lblDomBarrio;
        private System.Windows.Forms.Label lblDomDireccion;
        private System.Windows.Forms.Label lblDomCP;
        private System.Windows.Forms.TextBox txtDomCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Button btnAceptarDomicilio;
        private System.Windows.Forms.Button btnCancelarDom;
    }
}