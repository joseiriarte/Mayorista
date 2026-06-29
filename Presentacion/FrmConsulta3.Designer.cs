namespace Mayorista.Presentacion
{
    partial class FrmConsulta3
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
            this.btnSalirCon3 = new System.Windows.Forms.Button();
            this.lblCon3 = new System.Windows.Forms.Label();
            this.btnCon3 = new System.Windows.Forms.Button();
            this.dgvConsultas3 = new System.Windows.Forms.DataGridView();
            this.ColumnRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirCon3
            // 
            this.btnSalirCon3.Location = new System.Drawing.Point(726, 370);
            this.btnSalirCon3.Name = "btnSalirCon3";
            this.btnSalirCon3.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCon3.TabIndex = 10;
            this.btnSalirCon3.Text = "Salir";
            this.btnSalirCon3.UseVisualStyleBackColor = true;
            this.btnSalirCon3.Click += new System.EventHandler(this.btnSalirCon1_Click);
            // 
            // lblCon3
            // 
            this.lblCon3.AutoSize = true;
            this.lblCon3.Location = new System.Drawing.Point(9, 21);
            this.lblCon3.Name = "lblCon3";
            this.lblCon3.Size = new System.Drawing.Size(632, 26);
            this.lblCon3.TabIndex = 9;
            this.lblCon3.Text = "Mostrar el rubro, la cantidad total de artículos vendidos y el importe total fact" +
    "urado por rubro durante el primer semestre del año 2023.\r\nOrdenar por importe to" +
    "tal facturado de mayor a menor.";
            // 
            // btnCon3
            // 
            this.btnCon3.Location = new System.Drawing.Point(12, 69);
            this.btnCon3.Name = "btnCon3";
            this.btnCon3.Size = new System.Drawing.Size(75, 23);
            this.btnCon3.TabIndex = 8;
            this.btnCon3.Text = "Consultar";
            this.btnCon3.UseVisualStyleBackColor = true;
            this.btnCon3.Click += new System.EventHandler(this.btnCon3_Click);
            // 
            // dgvConsultas3
            // 
            this.dgvConsultas3.AllowUserToAddRows = false;
            this.dgvConsultas3.AllowUserToDeleteRows = false;
            this.dgvConsultas3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRubro,
            this.ColumnCantidad,
            this.ColumnImporte});
            this.dgvConsultas3.Location = new System.Drawing.Point(12, 116);
            this.dgvConsultas3.Name = "dgvConsultas3";
            this.dgvConsultas3.ReadOnly = true;
            this.dgvConsultas3.Size = new System.Drawing.Size(789, 227);
            this.dgvConsultas3.TabIndex = 7;
            // 
            // ColumnRubro
            // 
            this.ColumnRubro.HeaderText = "Rubro";
            this.ColumnRubro.Name = "ColumnRubro";
            this.ColumnRubro.ReadOnly = true;
            this.ColumnRubro.Width = 150;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad de artículos vendidos";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            this.ColumnCantidad.Width = 200;
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.HeaderText = "Importe total facturado";
            this.ColumnImporte.Name = "ColumnImporte";
            this.ColumnImporte.ReadOnly = true;
            this.ColumnImporte.Width = 200;
            // 
            // FrmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 408);
            this.Controls.Add(this.btnSalirCon3);
            this.Controls.Add(this.lblCon3);
            this.Controls.Add(this.btnCon3);
            this.Controls.Add(this.dgvConsultas3);
            this.Name = "FrmConsulta3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsulta3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirCon3;
        private System.Windows.Forms.Label lblCon3;
        private System.Windows.Forms.Button btnCon3;
        private System.Windows.Forms.DataGridView dgvConsultas3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporte;
    }
}