namespace Presentacion
{
    partial class Frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedores));
            this.dgvproveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelInventario = new System.Windows.Forms.Panel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefono_personal = new System.Windows.Forms.TextBox();
            this.txt_Telefono_empresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnFiltroProveedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelInventario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvproveedor
            // 
            this.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedor.Location = new System.Drawing.Point(168, 21);
            this.dgvproveedor.Name = "dgvproveedor";
            this.dgvproveedor.Size = new System.Drawing.Size(926, 289);
            this.dgvproveedor.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelInventario);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(168, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 257);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // PanelInventario
            // 
            this.PanelInventario.Controls.Add(this.txt_Email);
            this.PanelInventario.Controls.Add(this.txt_Telefono_personal);
            this.PanelInventario.Controls.Add(this.txt_Telefono_empresa);
            this.PanelInventario.Controls.Add(this.label6);
            this.PanelInventario.Controls.Add(this.label5);
            this.PanelInventario.Controls.Add(this.label4);
            this.PanelInventario.Controls.Add(this.txt_Cedula);
            this.PanelInventario.Controls.Add(this.txt_Nombres);
            this.PanelInventario.Controls.Add(this.txt_Apellidos);
            this.PanelInventario.Controls.Add(this.label3);
            this.PanelInventario.Controls.Add(this.label2);
            this.PanelInventario.Controls.Add(this.label1);
            this.PanelInventario.Location = new System.Drawing.Point(6, 19);
            this.PanelInventario.Name = "PanelInventario";
            this.PanelInventario.Size = new System.Drawing.Size(902, 221);
            this.PanelInventario.TabIndex = 25;
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Email.Location = new System.Drawing.Point(646, 168);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(206, 26);
            this.txt_Email.TabIndex = 37;
            // 
            // txt_Telefono_personal
            // 
            this.txt_Telefono_personal.Enabled = false;
            this.txt_Telefono_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Telefono_personal.Location = new System.Drawing.Point(646, 46);
            this.txt_Telefono_personal.Name = "txt_Telefono_personal";
            this.txt_Telefono_personal.Size = new System.Drawing.Size(206, 26);
            this.txt_Telefono_personal.TabIndex = 35;
            // 
            // txt_Telefono_empresa
            // 
            this.txt_Telefono_empresa.Enabled = false;
            this.txt_Telefono_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Telefono_empresa.Location = new System.Drawing.Point(646, 107);
            this.txt_Telefono_empresa.Name = "txt_Telefono_empresa";
            this.txt_Telefono_empresa.Size = new System.Drawing.Size(206, 26);
            this.txt_Telefono_empresa.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(425, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(425, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefono empresa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(425, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Telefono personal :";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Enabled = false;
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cedula.Location = new System.Drawing.Point(152, 43);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(206, 26);
            this.txt_Cedula.TabIndex = 31;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Enabled = false;
            this.txt_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Nombres.Location = new System.Drawing.Point(152, 112);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(206, 26);
            this.txt_Nombres.TabIndex = 26;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Enabled = false;
            this.txt_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Apellidos.Location = new System.Drawing.Point(152, 172);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(206, 26);
            this.txt_Apellidos.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellidos :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cedula :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombres :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Cerrar);
            this.groupBox2.Controls.Add(this.btn_Eliminar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Nuevo);
            this.groupBox2.Controls.Add(this.btn_Modificar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.Controls.Add(this.btn_Limpiar);
            this.groupBox2.Location = new System.Drawing.Point(168, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 67);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.White;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Location = new System.Drawing.Point(799, 19);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(109, 37);
            this.Btn_Cerrar.TabIndex = 185;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(665, 19);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(109, 37);
            this.btn_Eliminar.TabIndex = 184;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(402, 19);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 37);
            this.btn_Cancelar.TabIndex = 183;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(10, 19);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(109, 37);
            this.btn_Nuevo.TabIndex = 159;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click_1);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.White;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(275, 19);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(109, 37);
            this.btn_Modificar.TabIndex = 182;
            this.btn_Modificar.Text = "Editar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.White;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(144, 19);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(109, 37);
            this.btn_Guardar.TabIndex = 157;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Enabled = false;
            this.btn_Limpiar.Location = new System.Drawing.Point(533, 19);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(109, 37);
            this.btn_Limpiar.TabIndex = 27;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click_1);
            // 
            // txtfiltro
            // 
            this.txtfiltro.AcceptsReturn = true;
            this.txtfiltro.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.Location = new System.Drawing.Point(422, 681);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(453, 22);
            this.txtfiltro.TabIndex = 41;
            this.txtfiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltro_KeyPress);
            // 
            // btnFiltroProveedor
            // 
            this.btnFiltroProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroProveedor.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroProveedor.ForeColor = System.Drawing.Color.White;
            this.btnFiltroProveedor.Location = new System.Drawing.Point(920, 674);
            this.btnFiltroProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroProveedor.Name = "btnFiltroProveedor";
            this.btnFiltroProveedor.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroProveedor.TabIndex = 42;
            this.btnFiltroProveedor.Text = "Filtrar";
            this.btnFiltroProveedor.UseVisualStyleBackColor = true;
            this.btnFiltroProveedor.Click += new System.EventHandler(this.btnFiltroProveedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(195, 681);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Buscador por Nombre :";
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 744);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFiltroProveedor);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvproveedor);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Proveedores";
            this.Load += new System.EventHandler(this.Frm_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.PanelInventario.ResumeLayout(false);
            this.PanelInventario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvproveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelInventario;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Limpiar;
        internal System.Windows.Forms.Button btn_Guardar;
        internal System.Windows.Forms.Button btn_Modificar;
        internal System.Windows.Forms.Button btn_Nuevo;
        internal System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnFiltroProveedor;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox txt_Telefono_personal;
        private System.Windows.Forms.TextBox txt_Telefono_empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button Btn_Cerrar;
    }
}