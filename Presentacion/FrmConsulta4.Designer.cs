namespace Mayorista.Presentacion
{
    partial class FrmConsulta4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta4));
            this.btnSalirCon4 = new System.Windows.Forms.Button();
            this.lblCon4 = new System.Windows.Forms.Label();
            this.btnCon4 = new System.Windows.Forms.Button();
            this.dgvConsultas4 = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFacturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirCon4
            // 
            this.btnSalirCon4.Location = new System.Drawing.Point(726, 369);
            this.btnSalirCon4.Name = "btnSalirCon4";
            this.btnSalirCon4.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCon4.TabIndex = 10;
            this.btnSalirCon4.Text = "Salir";
            this.btnSalirCon4.UseVisualStyleBackColor = true;
            this.btnSalirCon4.Click += new System.EventHandler(this.btnSalirCon1_Click);
            // 
            // lblCon4
            // 
            this.lblCon4.AutoSize = true;
            this.lblCon4.Location = new System.Drawing.Point(9, 22);
            this.lblCon4.Name = "lblCon4";
            this.lblCon4.Size = new System.Drawing.Size(536, 26);
            this.lblCon4.TabIndex = 9;
            this.lblCon4.Text = resources.GetString("lblCon4.Text");
            // 
            // btnCon4
            // 
            this.btnCon4.Location = new System.Drawing.Point(12, 68);
            this.btnCon4.Name = "btnCon4";
            this.btnCon4.Size = new System.Drawing.Size(75, 23);
            this.btnCon4.TabIndex = 8;
            this.btnCon4.Text = "Consultar";
            this.btnCon4.UseVisualStyleBackColor = true;
            this.btnCon4.Click += new System.EventHandler(this.btnCon4_Click);
            // 
            // dgvConsultas4
            // 
            this.dgvConsultas4.AllowUserToAddRows = false;
            this.dgvConsultas4.AllowUserToDeleteRows = false;
            this.dgvConsultas4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnBarrio,
            this.ColumnFacturas,
            this.ColumnImporte});
            this.dgvConsultas4.Location = new System.Drawing.Point(12, 115);
            this.dgvConsultas4.Name = "dgvConsultas4";
            this.dgvConsultas4.ReadOnly = true;
            this.dgvConsultas4.Size = new System.Drawing.Size(789, 227);
            this.dgvConsultas4.TabIndex = 7;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre completo";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 150;
            // 
            // ColumnBarrio
            // 
            this.ColumnBarrio.HeaderText = "Barrio";
            this.ColumnBarrio.Name = "ColumnBarrio";
            this.ColumnBarrio.ReadOnly = true;
            this.ColumnBarrio.Width = 180;
            // 
            // ColumnFacturas
            // 
            this.ColumnFacturas.HeaderText = "Cantidad de facturas";
            this.ColumnFacturas.Name = "ColumnFacturas";
            this.ColumnFacturas.ReadOnly = true;
            this.ColumnFacturas.Width = 180;
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.HeaderText = "Importe total facturado";
            this.ColumnImporte.Name = "ColumnImporte";
            this.ColumnImporte.ReadOnly = true;
            this.ColumnImporte.Width = 220;
            // 
            // FrmConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 408);
            this.Controls.Add(this.btnSalirCon4);
            this.Controls.Add(this.lblCon4);
            this.Controls.Add(this.btnCon4);
            this.Controls.Add(this.dgvConsultas4);
            this.Name = "FrmConsulta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsulta4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirCon4;
        private System.Windows.Forms.Label lblCon4;
        private System.Windows.Forms.Button btnCon4;
        private System.Windows.Forms.DataGridView dgvConsultas4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporte;
    }
}