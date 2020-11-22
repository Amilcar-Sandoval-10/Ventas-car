namespace Presentacion
{
    partial class Frm_Buscador_Inventario
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
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.CheckBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.cbmodelo = new System.Windows.Forms.CheckBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.cbmarca = new System.Windows.Forms.CheckBox();
            this.dgvFiltroInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(426, 31);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 36;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(16, 37);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(90, 23);
            this.txtid.TabIndex = 33;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // cbid
            // 
            this.cbid.AutoSize = true;
            this.cbid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbid.Location = new System.Drawing.Point(27, 5);
            this.cbid.Margin = new System.Windows.Forms.Padding(2);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(43, 21);
            this.cbid.TabIndex = 32;
            this.cbid.Text = "Id";
            this.cbid.UseVisualStyleBackColor = true;
            this.cbid.CheckedChanged += new System.EventHandler(this.cbcodigo_CheckedChanged);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Enabled = false;
            this.txtmodelo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo.Location = new System.Drawing.Point(156, 37);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(90, 23);
            this.txtmodelo.TabIndex = 39;
            // 
            // cbmodelo
            // 
            this.cbmodelo.AutoSize = true;
            this.cbmodelo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmodelo.Location = new System.Drawing.Point(167, 5);
            this.cbmodelo.Margin = new System.Windows.Forms.Padding(2);
            this.cbmodelo.Name = "cbmodelo";
            this.cbmodelo.Size = new System.Drawing.Size(81, 21);
            this.cbmodelo.TabIndex = 38;
            this.cbmodelo.Text = "Modelo";
            this.cbmodelo.UseVisualStyleBackColor = true;
            this.cbmodelo.CheckedChanged += new System.EventHandler(this.cbmodelo_CheckedChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.Enabled = false;
            this.txtmarca.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(295, 37);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(90, 23);
            this.txtmarca.TabIndex = 41;
            // 
            // cbmarca
            // 
            this.cbmarca.AutoSize = true;
            this.cbmarca.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmarca.Location = new System.Drawing.Point(306, 5);
            this.cbmarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(72, 21);
            this.cbmarca.TabIndex = 40;
            this.cbmarca.Text = "Marca";
            this.cbmarca.UseVisualStyleBackColor = true;
            this.cbmarca.CheckedChanged += new System.EventHandler(this.cbmarca_CheckedChanged);
            // 
            // dgvFiltroInventario
            // 
            this.dgvFiltroInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroInventario.Location = new System.Drawing.Point(6, 88);
            this.dgvFiltroInventario.Name = "dgvFiltroInventario";
            this.dgvFiltroInventario.Size = new System.Drawing.Size(573, 183);
            this.dgvFiltroInventario.TabIndex = 42;
            this.dgvFiltroInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellClick_1);
            this.dgvFiltroInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellContentClick);
            // 
            // Frm_Buscador_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 283);
            this.Controls.Add(this.dgvFiltroInventario);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.cbmodelo);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbid);
            this.Name = "Frm_Buscador_Inventario";
            this.Text = "Frm_Buscador_Inventario";
            this.Load += new System.EventHandler(this.Frm_Buscador_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox cbid;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.CheckBox cbmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.CheckBox cbmarca;
        private System.Windows.Forms.DataGridView dgvFiltroInventario;
    }
}