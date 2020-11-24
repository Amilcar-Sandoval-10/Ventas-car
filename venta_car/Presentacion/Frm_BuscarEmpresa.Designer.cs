namespace Presentacion
{
    partial class Frm_BuscarEmpresa
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
            this.dgvFiltroInventario = new System.Windows.Forms.DataGridView();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbnombre = new System.Windows.Forms.CheckBox();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltroInventario
            // 
            this.dgvFiltroInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroInventario.Location = new System.Drawing.Point(11, 94);
            this.dgvFiltroInventario.Name = "dgvFiltroInventario";
            this.dgvFiltroInventario.Size = new System.Drawing.Size(573, 183);
            this.dgvFiltroInventario.TabIndex = 50;
            this.dgvFiltroInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellClick);
            this.dgvFiltroInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellContentClick);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(162, 43);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(90, 23);
            this.txtnombre.TabIndex = 47;
            // 
            // cbnombre
            // 
            this.cbnombre.AutoSize = true;
            this.cbnombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnombre.Location = new System.Drawing.Point(172, 11);
            this.cbnombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbnombre.Name = "cbnombre";
            this.cbnombre.Size = new System.Drawing.Size(87, 21);
            this.cbnombre.TabIndex = 46;
            this.cbnombre.Text = "Nombre";
            this.cbnombre.UseVisualStyleBackColor = true;
            this.cbnombre.CheckedChanged += new System.EventHandler(this.cbnombre_CheckedChanged);
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(337, 31);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 45;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(21, 43);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(90, 23);
            this.txtid.TabIndex = 44;
            // 
            // cbid
            // 
            this.cbid.AutoSize = true;
            this.cbid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbid.Location = new System.Drawing.Point(32, 11);
            this.cbid.Margin = new System.Windows.Forms.Padding(2);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(43, 21);
            this.cbid.TabIndex = 43;
            this.cbid.Text = "Id";
            this.cbid.UseVisualStyleBackColor = true;
            this.cbid.CheckedChanged += new System.EventHandler(this.cbid_CheckedChanged);
            // 
            // Frm_BuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 283);
            this.Controls.Add(this.dgvFiltroInventario);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbnombre);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbid);
            this.Name = "Frm_BuscarEmpresa";
            this.Text = "Frm_BuscarEmpresa";
            this.Load += new System.EventHandler(this.Frm_BuscarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltroInventario;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.CheckBox cbnombre;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox cbid;
    }
}