namespace Mayorista.Presentacion
{
    partial class FrmConsulta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta1));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCon1 = new System.Windows.Forms.Button();
            this.lblCon1 = new System.Windows.Forms.Label();
            this.btnSalirCon1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnTotal,
            this.ColumnPromedio,
            this.ColumnCantidadTotal});
            this.dgvConsultas.Location = new System.Drawing.Point(12, 67);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.Size = new System.Drawing.Size(776, 227);
            this.dgvConsultas.TabIndex = 0;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre completo";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 180;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total facturado";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Width = 180;
            // 
            // ColumnPromedio
            // 
            this.ColumnPromedio.HeaderText = "Promedio facturado";
            this.ColumnPromedio.Name = "ColumnPromedio";
            this.ColumnPromedio.ReadOnly = true;
            this.ColumnPromedio.Width = 180;
            // 
            // ColumnCantidadTotal
            // 
            this.ColumnCantidadTotal.HeaderText = "Cantidad total de articulos vendidos";
            this.ColumnCantidadTotal.Name = "ColumnCantidadTotal";
            this.ColumnCantidadTotal.ReadOnly = true;
            this.ColumnCantidadTotal.Width = 150;
            // 
            // btnCon1
            // 
            this.btnCon1.Location = new System.Drawing.Point(3, 38);
            this.btnCon1.Name = "btnCon1";
            this.btnCon1.Size = new System.Drawing.Size(75, 23);
            this.btnCon1.TabIndex = 1;
            this.btnCon1.Text = "Consultar";
            this.btnCon1.UseVisualStyleBackColor = true;
            this.btnCon1.Click += new System.EventHandler(this.btnCon1_Click);
            // 
            // lblCon1
            // 
            this.lblCon1.AutoSize = true;
            this.lblCon1.Location = new System.Drawing.Point(0, 9);
            this.lblCon1.Name = "lblCon1";
            this.lblCon1.Size = new System.Drawing.Size(802, 26);
            this.lblCon1.TabIndex = 5;
            this.lblCon1.Text = resources.GetString("lblCon1.Text");
            // 
            // btnSalirCon1
            // 
            this.btnSalirCon1.Location = new System.Drawing.Point(3, 415);
            this.btnSalirCon1.Name = "btnSalirCon1";
            this.btnSalirCon1.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCon1.TabIndex = 6;
            this.btnSalirCon1.Text = "Salir";
            this.btnSalirCon1.UseVisualStyleBackColor = true;
            this.btnSalirCon1.Click += new System.EventHandler(this.btnSalirCon1_Click);
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirCon1);
            this.Controls.Add(this.lblCon1);
            this.Controls.Add(this.btnCon1);
            this.Controls.Add(this.dgvConsultas);
            this.Name = "FrmConsulta1";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnCon1;
        private System.Windows.Forms.Label lblCon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadTotal;
        private System.Windows.Forms.Button btnSalirCon1;
    }
}