namespace Presentacion
{
    partial class Frm_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inventario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_inventario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_Stock_min = new System.Windows.Forms.TextBox();
            this.txt_Stock_max = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_inventario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 254);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_inventario);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 251);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los Datos";
            // 
            // panel_inventario
            // 
            this.panel_inventario.Controls.Add(this.label1);
            this.panel_inventario.Controls.Add(this.label7);
            this.panel_inventario.Controls.Add(this.txt_Stock);
            this.panel_inventario.Controls.Add(this.txt_Stock_min);
            this.panel_inventario.Controls.Add(this.txt_Stock_max);
            this.panel_inventario.Controls.Add(this.txt_precio);
            this.panel_inventario.Controls.Add(this.txt_modelo);
            this.panel_inventario.Controls.Add(this.txt_marca);
            this.panel_inventario.Controls.Add(this.label4);
            this.panel_inventario.Controls.Add(this.label6);
            this.panel_inventario.Controls.Add(this.label5);
            this.panel_inventario.Controls.Add(this.label2);
            this.panel_inventario.Controls.Add(this.label3);
            this.panel_inventario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_inventario.ForeColor = System.Drawing.Color.White;
            this.panel_inventario.Location = new System.Drawing.Point(5, 24);
            this.panel_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.panel_inventario.Name = "panel_inventario";
            this.panel_inventario.Size = new System.Drawing.Size(1045, 211);
            this.panel_inventario.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stock :";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(721, 46);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(173, 26);
            this.txt_Stock.TabIndex = 12;
            // 
            // txt_Stock_min
            // 
            this.txt_Stock_min.Location = new System.Drawing.Point(721, 99);
            this.txt_Stock_min.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stock_min.Name = "txt_Stock_min";
            this.txt_Stock_min.Size = new System.Drawing.Size(173, 26);
            this.txt_Stock_min.TabIndex = 11;
            // 
            // txt_Stock_max
            // 
            this.txt_Stock_max.Location = new System.Drawing.Point(721, 154);
            this.txt_Stock_max.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stock_max.Name = "txt_Stock_max";
            this.txt_Stock_max.Size = new System.Drawing.Size(173, 26);
            this.txt_Stock_max.TabIndex = 10;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(233, 155);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(173, 26);
            this.txt_precio.TabIndex = 9;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(233, 96);
            this.txt_modelo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(173, 26);
            this.txt_modelo.TabIndex = 8;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(233, 45);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(173, 26);
            this.txt_marca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock Minimo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock Maximo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Modificar);
            this.groupBox2.Controls.Add(this.Btn_quitar);
            this.groupBox2.Controls.Add(this.btn_Nuevo);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_añadir);
            this.groupBox2.Controls.Add(this.Btn_Cerrar);
            this.groupBox2.Controls.Add(this.btn_Limpiar);
            this.groupBox2.Location = new System.Drawing.Point(22, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1080, 100);
            this.groupBox2.TabIndex = 155;
            this.groupBox2.TabStop = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.White;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(624, 32);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(109, 37);
            this.btn_Modificar.TabIndex = 183;
            this.btn_Modificar.Text = "Editar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.White;
            this.Btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_quitar.Image")));
            this.Btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_quitar.Location = new System.Drawing.Point(781, 32);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(109, 37);
            this.Btn_quitar.TabIndex = 159;
            this.Btn_quitar.Text = "Eliminar";
            this.Btn_quitar.UseVisualStyleBackColor = false;
            this.Btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(24, 32);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(109, 37);
            this.btn_Nuevo.TabIndex = 158;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(176, 32);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 37);
            this.btn_Cancelar.TabIndex = 157;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_añadir
            // 
            this.btn_añadir.BackColor = System.Drawing.Color.White;
            this.btn_añadir.Enabled = false;
            this.btn_añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_añadir.Image = ((System.Drawing.Image)(resources.GetObject("btn_añadir.Image")));
            this.btn_añadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_añadir.Location = new System.Drawing.Point(473, 32);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(109, 37);
            this.btn_añadir.TabIndex = 156;
            this.btn_añadir.Text = "Guardar";
            this.btn_añadir.UseVisualStyleBackColor = false;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.White;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Location = new System.Drawing.Point(933, 32);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(109, 37);
            this.Btn_Cerrar.TabIndex = 155;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Enabled = false;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_Limpiar.Location = new System.Drawing.Point(328, 32);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(109, 37);
            this.btn_Limpiar.TabIndex = 154;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(673, 656);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 157;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.Location = new System.Drawing.Point(304, 662);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(287, 23);
            this.txtfiltro.TabIndex = 156;
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1211, 705);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Inventario";
            this.Load += new System.EventHandler(this.Frm_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_inventario.ResumeLayout(false);
            this.panel_inventario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_inventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_Stock_min;
        private System.Windows.Forms.TextBox txt_Stock_max;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button Btn_quitar;
        internal System.Windows.Forms.Button btn_Nuevo;
        internal System.Windows.Forms.Button btn_Cancelar;
        internal System.Windows.Forms.Button btn_añadir;
        internal System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button btn_Limpiar;
        internal System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.TextBox txtfiltro;
    }
}