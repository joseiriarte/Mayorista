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
            this.lblDomicilios = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnNuevoCl = new System.Windows.Forms.Button();
            this.btnEditarCl = new System.Windows.Forms.Button();
            this.btnEliminarCl = new System.Windows.Forms.Button();
            this.btnNuevoDom = new System.Windows.Forms.Button();
            this.btnEditarDom = new System.Windows.Forms.Button();
            this.btnEliminarDom = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.gbCliente.Controls.Add(this.dataGridView2);
            this.gbCliente.Controls.Add(this.dataGridView1);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Controls.Add(this.lblCliente);
            this.gbCliente.Location = new System.Drawing.Point(60, 65);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(533, 570);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
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
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(456, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(357, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(129, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(146, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(205, 20);
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
            // btnNuevoCl
            // 
            this.btnNuevoCl.Location = new System.Drawing.Point(30, 242);
            this.btnNuevoCl.Name = "btnNuevoCl";
            this.btnNuevoCl.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCl.TabIndex = 6;
            this.btnNuevoCl.Text = "Nuevo";
            this.btnNuevoCl.UseVisualStyleBackColor = true;
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
            // btnEliminarCl
            // 
            this.btnEliminarCl.Location = new System.Drawing.Point(192, 242);
            this.btnEliminarCl.Name = "btnEliminarCl";
            this.btnEliminarCl.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCl.TabIndex = 8;
            this.btnEliminarCl.Text = "Eliminar";
            this.btnEliminarCl.UseVisualStyleBackColor = true;
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
            // btnEditarDom
            // 
            this.btnEditarDom.Location = new System.Drawing.Point(111, 477);
            this.btnEditarDom.Name = "btnEditarDom";
            this.btnEditarDom.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDom.TabIndex = 9;
            this.btnEditarDom.Text = "Editar";
            this.btnEditarDom.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDomicilios;
        private System.Windows.Forms.Button btnEliminarDom;
        private System.Windows.Forms.Button btnEditarDom;
        private System.Windows.Forms.Button btnNuevoDom;
        private System.Windows.Forms.Button btnEliminarCl;
        private System.Windows.Forms.Button btnEditarCl;
        private System.Windows.Forms.Button btnNuevoCl;
        private System.Windows.Forms.Button btnAtras;
    }
}