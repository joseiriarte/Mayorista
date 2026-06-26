namespace Mayorista.Presentacion
{
    partial class FrmConsulta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta2));
            this.btnSalirCon2 = new System.Windows.Forms.Button();
            this.lblCon2 = new System.Windows.Forms.Label();
            this.btnCon2 = new System.Windows.Forms.Button();
            this.dgvConsultas2 = new System.Windows.Forms.DataGridView();
            this.ColumnFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormadepago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirCon2
            // 
            this.btnSalirCon2.Location = new System.Drawing.Point(726, 371);
            this.btnSalirCon2.Name = "btnSalirCon2";
            this.btnSalirCon2.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCon2.TabIndex = 10;
            this.btnSalirCon2.Text = "Salir";
            this.btnSalirCon2.UseVisualStyleBackColor = true;
            this.btnSalirCon2.Click += new System.EventHandler(this.btnSalirCon2_Click);
            // 
            // lblCon2
            // 
            this.lblCon2.AutoSize = true;
            this.lblCon2.Location = new System.Drawing.Point(12, 31);
            this.lblCon2.Name = "lblCon2";
            this.lblCon2.Size = new System.Drawing.Size(575, 13);
            this.lblCon2.TabIndex = 9;
            this.lblCon2.Text = "Mostrar las 10 facturas con el mayor importe  pagadas con transferencia o efectiv" +
    "o entre el 03/02/2019 y el 08/10/2019";
            // 
            // btnCon2
            // 
            this.btnCon2.Location = new System.Drawing.Point(12, 70);
            this.btnCon2.Name = "btnCon2";
            this.btnCon2.Size = new System.Drawing.Size(75, 23);
            this.btnCon2.TabIndex = 8;
            this.btnCon2.Text = "Consultar";
            this.btnCon2.UseVisualStyleBackColor = true;
            this.btnCon2.Click += new System.EventHandler(this.btnCon2_Click);
            // 
            // dgvConsultas2
            // 
            this.dgvConsultas2.AllowUserToAddRows = false;
            this.dgvConsultas2.AllowUserToDeleteRows = false;
            this.dgvConsultas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFactura,
            this.ColumnFecha,
            this.ColumnImporte,
            this.ColumnFormadepago});
            this.dgvConsultas2.Location = new System.Drawing.Point(12, 117);
            this.dgvConsultas2.Name = "dgvConsultas2";
            this.dgvConsultas2.ReadOnly = true;
            this.dgvConsultas2.Size = new System.Drawing.Size(789, 227);
            this.dgvConsultas2.TabIndex = 7;
            // 
            // ColumnFactura
            // 
            this.ColumnFactura.HeaderText = "Factura";
            this.ColumnFactura.Name = "ColumnFactura";
            this.ColumnFactura.ReadOnly = true;
            this.ColumnFactura.Width = 150;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.Width = 180;
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.HeaderText = "Importe";
            this.ColumnImporte.Name = "ColumnImporte";
            this.ColumnImporte.ReadOnly = true;
            this.ColumnImporte.Width = 180;
            // 
            // ColumnFormadepago
            // 
            this.ColumnFormadepago.HeaderText = "Forma de Pago";
            this.ColumnFormadepago.Name = "ColumnFormadepago";
            this.ColumnFormadepago.ReadOnly = true;
            this.ColumnFormadepago.Width = 220;
            // 
            // FrmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 408);
            this.Controls.Add(this.btnSalirCon2);
            this.Controls.Add(this.lblCon2);
            this.Controls.Add(this.btnCon2);
            this.Controls.Add(this.dgvConsultas2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirCon2;
        private System.Windows.Forms.Label lblCon2;
        private System.Windows.Forms.Button btnCon2;
        private System.Windows.Forms.DataGridView dgvConsultas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormadepago;
    }
}