namespace Presentacion
{
    partial class Frm_Buscardor_Clientes
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
            this.dgvFiltroCliente = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.CheckBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cbCedula = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltroCliente
            // 
            this.dgvFiltroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroCliente.Location = new System.Drawing.Point(14, 105);
            this.dgvFiltroCliente.Name = "dgvFiltroCliente";
            this.dgvFiltroCliente.Size = new System.Drawing.Size(601, 177);
            this.dgvFiltroCliente.TabIndex = 49;
            this.dgvFiltroCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroCliente_CellClick);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(41, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 48;
            // 
            // cbid
            // 
            this.cbid.AutoSize = true;
            this.cbid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbid.Location = new System.Drawing.Point(54, 11);
            this.cbid.Margin = new System.Windows.Forms.Padding(2);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(43, 21);
            this.cbid.TabIndex = 47;
            this.cbid.Text = "Id";
            this.cbid.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(345, 45);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(90, 23);
            this.txtCedula.TabIndex = 46;
            // 
            // cbCedula
            // 
            this.cbCedula.AutoSize = true;
            this.cbCedula.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCedula.Location = new System.Drawing.Point(358, 11);
            this.cbCedula.Margin = new System.Windows.Forms.Padding(2);
            this.cbCedula.Name = "cbCedula";
            this.cbCedula.Size = new System.Drawing.Size(77, 21);
            this.cbCedula.TabIndex = 45;
            this.cbCedula.Text = "Cedula";
            this.cbCedula.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(199, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 44;
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(496, 33);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 43;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // cbNombre
            // 
            this.cbNombre.AutoSize = true;
            this.cbNombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombre.Location = new System.Drawing.Point(212, 11);
            this.cbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(87, 21);
            this.cbNombre.TabIndex = 42;
            this.cbNombre.Text = "Nombre";
            this.cbNombre.UseVisualStyleBackColor = true;
            // 
            // Frm_Buscardor_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 309);
            this.Controls.Add(this.dgvFiltroCliente);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cbCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.cbNombre);
            this.Name = "Frm_Buscardor_Clientes";
            this.Text = "Frm_Buscardor_Clientes";
            this.Load += new System.EventHandler(this.Frm_Buscardor_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltroCliente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox cbid;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.CheckBox cbCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.CheckBox cbNombre;
    }
}