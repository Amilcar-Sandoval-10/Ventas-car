namespace Presentacion
{
    partial class Frm_Buscardor_Proveedor
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnFiltroProveedor = new System.Windows.Forms.Button();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cbCedula = new System.Windows.Forms.CheckBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.CheckBox();
            this.dgvFiltroInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(188, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 35;
            // 
            // btnFiltroProveedor
            // 
            this.btnFiltroProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroProveedor.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroProveedor.Location = new System.Drawing.Point(485, 48);
            this.btnFiltroProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroProveedor.Name = "btnFiltroProveedor";
            this.btnFiltroProveedor.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroProveedor.TabIndex = 34;
            this.btnFiltroProveedor.Text = "Filtrar";
            this.btnFiltroProveedor.UseVisualStyleBackColor = true;
            this.btnFiltroProveedor.Click += new System.EventHandler(this.btnFiltroProveedor_Click);
            // 
            // cbNombre
            // 
            this.cbNombre.AutoSize = true;
            this.cbNombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombre.Location = new System.Drawing.Point(201, 26);
            this.cbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(87, 21);
            this.cbNombre.TabIndex = 29;
            this.cbNombre.Text = "Nombre";
            this.cbNombre.UseVisualStyleBackColor = true;
            this.cbNombre.CheckedChanged += new System.EventHandler(this.cbNombre_CheckedChanged_1);
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(334, 60);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(90, 23);
            this.txtCedula.TabIndex = 38;
            // 
            // cbCedula
            // 
            this.cbCedula.AutoSize = true;
            this.cbCedula.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCedula.Location = new System.Drawing.Point(347, 26);
            this.cbCedula.Margin = new System.Windows.Forms.Padding(2);
            this.cbCedula.Name = "cbCedula";
            this.cbCedula.Size = new System.Drawing.Size(77, 21);
            this.cbCedula.TabIndex = 37;
            this.cbCedula.Text = "Cedula";
            this.cbCedula.UseVisualStyleBackColor = true;
            this.cbCedula.CheckedChanged += new System.EventHandler(this.cbCedula_CheckedChanged);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(30, 60);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 40;
            // 
            // cbid
            // 
            this.cbid.AutoSize = true;
            this.cbid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbid.Location = new System.Drawing.Point(43, 26);
            this.cbid.Margin = new System.Windows.Forms.Padding(2);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(43, 21);
            this.cbid.TabIndex = 39;
            this.cbid.Text = "Id";
            this.cbid.UseVisualStyleBackColor = true;
            this.cbid.CheckedChanged += new System.EventHandler(this.cbid_CheckedChanged);
            // 
            // dgvFiltroInventario
            // 
            this.dgvFiltroInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroInventario.Location = new System.Drawing.Point(3, 120);
            this.dgvFiltroInventario.Name = "dgvFiltroInventario";
            this.dgvFiltroInventario.Size = new System.Drawing.Size(601, 177);
            this.dgvFiltroInventario.TabIndex = 41;
            this.dgvFiltroInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellClick);
            // 
            // Frm_Buscardor_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 309);
            this.Controls.Add(this.dgvFiltroInventario);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cbCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnFiltroProveedor);
            this.Controls.Add(this.cbNombre);
            this.Name = "Frm_Buscardor_Proveedor";
            this.Text = "Frm_Buscardor_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Buscardor_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnFiltroProveedor;
        private System.Windows.Forms.CheckBox cbNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.CheckBox cbCedula;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox cbid;
        private System.Windows.Forms.DataGridView dgvFiltroInventario;
    }
}